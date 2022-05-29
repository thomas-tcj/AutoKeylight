module Data.AutoKeylight

open System
open System.IO
open Microsoft.Win32
open RegistryUtils.RegistryMonitor
open Debounce


let webcamRegkey = @"Software\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\webcam"


type AutoKeylight() =
    let onCamEnable = new DelegateEvent<EventHandler<_>>()
    let onCamDisable = new DelegateEvent<EventHandler<_>>()

    let error (e: ErrorEventArgs) = e.GetException() |> raise

    member val private Monitor = new RegistryMonitor(RegistryHive.CurrentUser, webcamRegkey)

    member private this.Debounce = new Debounce(1000, false, this.cameraStateChanged)

    [<CLIEvent>]
    member this.OnCamEnable = onCamEnable.Publish

    [<CLIEvent>]
    member this.OnCamDisable = onCamDisable.Publish

    /// Triggered when the webcam registry has changed. Since this can be triggered multiple times when enabling or
    /// disabling the camera, use a debounce that calls cameraStateChanged once if triggered multiple times in a single second.
    member private this.cameraRegistryChanged _ =
        this.Debounce.Bounce()

    /// Triggered when the state of the camera has changed according to the registry.
    /// Loop through the relevant registry keys to check if the camera is currently enabled or disabled.
    member private this.cameraStateChanged () =
        use key = Registry.CurrentUser.OpenSubKey(webcamRegkey)

        let rec isCamUsed (key: RegistryKey) =
            if (Array.contains "LastUsedTimeStop" (key.GetValueNames()) ) then
                    match key.GetValue("LastUsedTimeStop") with
                    | :? int64 as long -> long = 0
                    | _ -> false
            else
                key.GetSubKeyNames()
                |> Array.toList
                |> List.map 
                    (fun (x: string) -> 
                        use subKey = key.OpenSubKey(x)
                        isCamUsed subKey
                    )
                |> List.exists id

        if isCamUsed key then 
            onCamEnable.Trigger([|this ; null|])
        else 
            onCamDisable.Trigger([|this ; null|])

    member this.Start() =
        this.Monitor.RegChanged.Add(this.cameraRegistryChanged)
        this.Monitor.Error.Add(error)
        this.Monitor.Start()

    member this.Stop() =
        this.Monitor.Stop()
        this.Monitor.Dispose()

    interface IDisposable with
        member this.Dispose () = this.Stop()
