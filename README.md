# AutoKeylight
Automatically turn on/off your Elgato Keylight or Keylight air on webcam usage.

# Usage
* Download the latest release [here](https://github.com/Dynitios/AutoKeylight/releases).
* Enter the IP address of your keylight.

# Finding your keylight IP
As of yet I'm not convinced there is an easy method to find the IP of your keylight. Here are several things you could try. **Note that currently the IP address is only validated when the state of the webcam changes, so keep that in mind when looking for the correct IP address.**

## Using ARP
Using the windows command line, you can use the commmand `arp -a` to provide you with a list of known IP adresses in your network. One option is to try these devices one by one, however if there's a lot it might be worth looking into Nmap.

## Using Nmap
Using the command `nmap -p 9123 (ip range)` you can find which IP addresses have port 9123 open, which is the port that the elgato keylight uses. This will considerably lower the amount of possible IP's you are dealing with.
Example: `nmap -p 9123 192.168.178.*` will scan all ip adresses between `192.168.178.1` and `192.168.178.255`.
