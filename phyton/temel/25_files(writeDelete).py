fileToAppend=open("24_dosyaDeneme.txt","a")
fileToAppend.write("\n")#boşluk bırak
fileToAppend.write("ömer")
fileToAppend=open("24_dosyaDeneme.txt","w")
fileToAppend.write("sadece ben ") #bütün dosyanın üzerine yazar
fileToAppend.close()
import os
if os.path.exists("24_dosyaDeneme.txt"): #dosyanın var olup olmadığını kontrol eder
    os.remove("24_dosyaDeneme.txt")#dosyayı silmeni sağlar. dosya yoksa sıkıntı çıkarmaz.
else:
    print("dosya yok")
    
osm.rmdir("empty")#klasör silmeni sağlar. empty klasör ismidir. oraya isim yazarsın.