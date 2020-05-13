import sqlite3
connection = sqlite3.connect("chinook.db") #bu şekilde aynı dosyadaki veritabanına ulaşırsın
# cursor =connection.execute("select * from customers") #* tümünü demektir. customerstaki tüm verilere ulaş.
cursor=connection.execute("select FirstName,LastName from customers where city ='Prague' or city ='Berlin'") #bu şekilde ilk isim ve son isimlere ulaşırsın ama sadece prague lı olanlara ! veya berlinli olanlara.
for row in cursor:
    print("First Name = "  + row[0])
    print("Last Name = " + row[1])
connection.close()