import sqlite3
def insertCustomer():
    connection = sqlite3.connect("chinook.db")
    connection.execute(" insert into customers(firstName,lastName,city,email) values ('Omer','Faruk','Mardin','OmerFg@gmail.com')") # müşterilere istediğimiz satırlara istediğimiz verileri atayabiliriz. BAZI ZORUNLU SATIR BİLGİLERİ GİRİLMELİDİR UYARISINI YAPAR.
    connection.commit()
    connection.close()

insertCustomer()
