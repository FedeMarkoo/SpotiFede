import pafy
import requests
asd="metallica unforgiven"
pafy.new(requests.get(r'http://www.google.com/search?q=' + asd + ' www.youtube.com/watch?v=&btnI').url).getbestaudio().download()
