import pandas as pd
notlar = pd.read_csv("original.csv")
notlar.columns=["Last name","First name","SSN","test1","test2","test3","test4","final","sonuç"]
print(notlar)
print(notlar.loc[:,"First name"]) #tümünü
print(notlar.loc[:5,"First name"]) # 5 dahildir.
print(notlar.loc[:4,"First name":"test4"]) #isimden test4 e kadar tüm kolonların ilk 5 indexini ver.
print(notlar.loc[:4,["First name","test4"]]) #bu şekilde sadece isim ve test 4 ü alabilirsin.
print(notlar.loc[:4,:"test4"]) #baştan itibaren test 4 e kadarki verilerin ilk 4 indexini yaz
print(notlar.loc[::-1,:"First name"]) #tersten getirir