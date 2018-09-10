import requests
import re
import sys
name=sys.argv[0]
buscar=''
for arg in sys.argv:
    if not arg is name:
        buscar+=arg+' '
url = 'http://www.google.com.ar/search?q='+buscar

regex = r'Artista.*">([^<]+)<\/a.*Álbum.*">(?:&#[\w\d]+;)?([^<]+)<\/a.*Fecha de lanzamiento.{15,45}">(\d{4})<\/span>'

test_str = requests.get(url).text
matches = re.finditer(regex, test_str, re.MULTILINE)

artista=""
album=""
ano=""

for matchNum, match in enumerate(matches):
    matchNum = matchNum + 1
    artista=match.group(1)
    album=match.group(2)
    ano=match.group(3)

if len(artista) ==  0:
    regex = r'Artista.*">([^<]+)<\/a>.*Álbum.*">([\w ]+)<\/a>.*Fecha de lanzamiento.*">(\d{4})<\/'
    test_str = requests.get(url).text
    matches = re.finditer(regex, test_str, re.MULTILINE)

    for matchNum, match in enumerate(matches):
        matchNum = matchNum + 1
        artista=match.group(1)
        album=match.group(2)
        ano=match.group(3)
        
if len(artista) !=  0:
    print(artista+';'+album+';'+ano)
else:
    if "Our systems have detected unusual traffic from your computer network." in test_str:
        print("Demasiados intentos. Google te bloqueo")
    else:
        f=open("salida.txt","w")
        f.write(test_str)
        print(url)
