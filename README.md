# YTArchiving

A WinForm UI that wraps the yt-dlp project and provides the ability to have a persistent curated list of "Subscriptions" organised by folder for easy archiving.

## Quick Start
* Build the GUI project
* Get the yt-dlp.exe from https://github.com/yt-dlp/yt-dlp/releases and store it in the folder "ExternalBinaries"
* Get the ffmpeg.exe from https://ffmpeg.org/download.html#build-windows and store it in the folder "ExternalBinaries"
* Run the YTArchivingGUI.exe and use the text box to set where you want the output to go
* Optional: Click the LoadPreset button for an example library of subscriptions
* Add a subfolder and then add subscriptions as desired
* Either: 1) select a subscription and click "Sync one" or  2) click "Sync all"

## Extension and Modification
This is in a "minimum viable product" state. 
* If you want to adapt it to your requirements then the most likely place to edit is the YTDownloader class where the yt-dlp arguments are stored. 
* I have features that would be nice to implement, feel free to get involved as you wish.
