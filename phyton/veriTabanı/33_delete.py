import sqlite3
connection = sqlite3.connect("chinook.db") 
cursor=connection.execute("delete from customers where customerid = 60 or city = 'realMardin'") # id si 60 olanı sil. customer tablosu içerisinden !or veya and bağlaçlarını yapabilirsin.
connection.commit()
connection.close()