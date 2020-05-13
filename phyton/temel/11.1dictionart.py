#set gibi sırasızdır
#bir keye karşılık veri tutar herşey anahtar olabilir 
#örneğin bir sözlük book: kitap book key kitap ise bir veridir.

sozluk={ 
        "book":"kitap" ,1.2:"one","game":1
        }
print(sozluk)
print(sozluk[1.2])
sozluk["book"] ="kitap 1"
sozluk["pencil"] ="kalem" #olmayan bir keyi verip yeni değer atayabilirsin.
print(sozluk["book"])

sozluk2 = dict(kitap=" kalem" ,abi="game") #buda constructor şeklinde açmaktır. sadece harfler kullanılır keylerde
print(sozluk2["abi"])

del (sozluk["book"]) #sözlükten book keyini ve verisini siler
#leni de burada kullanabilirsin.