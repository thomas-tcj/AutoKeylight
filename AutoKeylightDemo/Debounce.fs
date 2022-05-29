module Data.Debounce


/// Provides a stereotypical JavaScript-like "debounce" service for events.
/// Set initialBounce to true to cause a inject a bounce when first the debouncer is first constructed.
type Debounce(timeout, initialBounce, fn) as self =
    let debounce fn timeout = MailboxProcessor.Start(fun agent -> 
        let rec loop ida idb = async {
            let! r = agent.TryReceive(timeout)
            match r with
            | Some _ -> return! loop ida (idb + 1)
            | None when ida <> idb -> fn (); return! loop idb idb
            | None -> return! loop ida idb
        }
        loop 0 0)
 
    let mailbox = debounce fn timeout
    do if initialBounce then self.Bounce()
 
    /// Calls the function, after debouncing has been applied.
    member __.Bounce() = mailbox.Post(null)