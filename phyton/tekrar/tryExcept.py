print(round(1.6))
# yuvarlama yapar

def yuvarlama():
    girdi = input("sayı gir")
    # print(" sonuç {}" .format(round(float(girdi))))
    # ya string girerse ?
    try:
        girdi = float(girdi)
        print(" sonuç {}" .format(round(girdi)))
    except:
        print("girdi dönüştürülemez")
    finally:
        print(" sonuç {} hatalı" .format(girdi))
yuvarlama()

try:
    z = 5+'a'
    print(z)
except TypeError:
    print(TypeError)
# hata türünü düzgün yazmalısın.