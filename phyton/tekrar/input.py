x = input("sayı gir ")
print(type(x))
# kullanıcıdan alınan değer string olarak alınır sen bunu casting edebilirsin
print(type(int(x)))
print(x)

def validation():
    y=input("bir tane daha ")
    if y.isdigit():
            print("bu bir sayı")
    elif '@' in y:
        print("@ var")
        

validation()