### About
Server app to host your own CBR/CBZ comic server so you can view your comics on any device that has a web browser!

### Setup Using IIS (only Windows)
```
1. Turn on IIS in your Windows features. Create an IIS site called WebComicViewer. Change authentication on that site to be your user so you have access to all the files on your PC.
2. Open the project solution in Visual Studio. Press Publish and type in the site info to publish the files. _(may need Admin privs on VS)_
3. Edit the `settings.json` file with a text editor like VSCode. Edit the `Comics_Directory` variable to your comics directory. Path string must be JSON safe.
```

### Setup Using Docker (Windows, MacOS, Linux)
```
1. Install [Docker](https://www.docker.com).
2. Edit the `docker-compose.yml` file with a text editor and change the comics directory path left of the `:`.
3. Open Terminal and use the command `docker-compose create`.
4. Now in docker, start up the container.
```

If you want to view your comics on other devices edit your Firewall rules and add/enable inbound 13050 port on your server computer.

If you want to view your comics outside your local home network, edit your router's forward port 13050 to point to your server computer's IP.

Visit `https://localhost:13050`, `https://(PC_IP):13050` or `https://(NETWORK_IP):13050` to view your comics!
