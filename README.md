# FetchDataFromYouTube
FetchDataFromYouTube
This is a project for fetching all video details of a desired YouTube Channels. With 2 different approaches, developed in .net core 5.0 C#.

Approach with the html view agility pack.
Approach with Selenium pack.
In First approach; there is no possibility to execute JavaScript because of that limited video displayed. And methods fetch the video information on actual htlm view which is at the beginning. But the advantage is; no need to run the browser.

In the second Approach; Selenium web driver used. Obviously it runs browser driver,passes the YouTube cookies question and reaches the target page which is the videos page of a YouTube Chanel. The advantage of this method, after browser opens scrolls down till the end of the page. Useful to fetch data from the YT channels have large number of Videos.

By default, I set the methods to get the link attributes. For presentation purpose, it prints to the console the required property of the desired class.

Possible to extend features like;

adding the fetched data to SQL or non SQL database.

Or saving as XLS, CVS, XML, JSON, etc.

If you have a question, please open issue.

Enjoy !
