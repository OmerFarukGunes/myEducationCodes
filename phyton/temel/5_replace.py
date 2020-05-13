mesaj="merhaba dünya"
print(mesaj.replace("ü","u"))#harfleri yerleştirir ancak böyle yaparsan mesaj değişmez
print(mesaj)
mesaj=mesaj.replace("ü","u") #bu şekilde tamamen değişir
print(mesaj)
print(mesaj.replace("a","e",2)) #2 tane ayı e yapar