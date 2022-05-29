### About
Simple ASP.NET web app to view your CBR/CBZ comics on any device.

### How To Setup
1. Turn on IIS in your Windows features. Create an IIS site called WebComicViewer. Change authentication on that site to be your user so you have access to all the files on your PC.
2. Open the project solution in Visual Studio. Press Publish and type in the site info to publish the files. _(may need Admin privs on VS)_
3. Edit the `settings.json` file with a text editor like VSCode. Edit the `Comics_Directory` variable to your comics directory. Path string must be JSON safe.
4. Visit `http://localhost:13050` or `http://(PC_IP_HERE):13050`
5. If you want to view them on other devices, edit your Firewall rules and add/enable inbound 13050 port.