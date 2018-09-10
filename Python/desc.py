import pafy
import requests
import sys
name=sys.argv[0]
buscar=''
for arg in sys.argv:
    if not arg is name:
        buscar+=arg+' '
pafy.new(requests.get(r'http://www.google.com/search?q=' + buscar + 'www.youtube.com/watch?v=&btnI').url).getbestaudio().download()
