try: #aşağıdaki kodu dene
    sayi =int (input("sayi giriniz"))
#eğer olurda kullanıcı 2b tarzında hem char hem int value girerse hata alırsın. 
#ve devam yazamazsın ekrana normal şartlarda ama try except kullanırsan kod devam eder
except ValueError: #hatayı bu şekilde yazabilirsin.
    print("gecersiz veri hatası")
# except ValueError,ZeroDivisionError: birden fazla hatada yapabilirsin.
except: #veya yazmayabilirsin.
    print("hata bilinmiyor")
finally: #en sonda her türlü çalışır.
    print("işlemler bitti")
print("devam")