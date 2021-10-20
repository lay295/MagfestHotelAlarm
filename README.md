# Magfest Hotel Alarm
![image](https://user-images.githubusercontent.com/1060681/138006837-ff45dd66-7785-4314-9869-a648a5f4158d.png)

## What is this?
Every year there is a convention on the east coast I go to called [MAGFest](https://super.magfest.org/) and there is a hotel lottery system. After the lottery system where you're randomized in the queue, everyone is allowed to book rooms after a few days. This program simply monitors the hotel block's API to notify you when a room is avaliable.

## How do I use this?
Just go to the [releases](https://github.com/lay295/MagfestHotelAlarm/releases) section and download and run the latest version. Currently it's set to monitor for MAGFest 2022 but i'll try and update this program every year, after I get my own hotel of course ;)

Once you've ran the program, 
- Select a sound file that's in .wav format for example [this one](http://home.freeuk.net/soundstuff/sounds/wavs1/alarm-intruder-effect-ver1.wav)
- Set the max distance you're willing to have the hotel (For example if you want walking distance to the Gaylord, put 0.1 miles)
- Set how often you want to check
- Hit start and wait for the program to go off :)

Once it detects a hotel within the distance, it should play your sound file and open a web browser to the hotel block booking page. Just click "Test Settings" button to make sure your sound file and opening the web browser works.
