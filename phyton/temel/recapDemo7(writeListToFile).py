ogrenciler=["Ömer","Faruk","Gunes","Orkun"]

fileToAppend= open("Students","a")

for ogrenci in ogrenciler:
    fileToAppend.write(ogrenci)
    fileToAppend.write("\n")
fileToAppend.close()