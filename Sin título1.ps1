$var=Get-ChildItem -Recurse | Where-Object -Property Extension -EQ ".mp3" | Select-Object -Property Name,FullName
$var[2].Name
Python "C:\Users\fedem\Escritorio\getdata.py" $var[2].Name
