import pandas as pd
url = "https://raw.githubusercontent.com/justmarkham/pandas-videos/master/data/ufo.csv"
data=pd.read_csv(url) #urlden bu şekilde okursun
print(data.shape)
data=data.dropna(how="any") #boş olan tüm verileri siler. eğer satırlardan herhangi birinde boşluk varsa onu tamamen siler.
#how = "any" yi yamak zorunda değilsin 
#defaulttur. eğer satırda herhangi bir veri bozuksa tüm satırı sil demek
#how = "all" ise bir satırda tüm veriler null ise o satırı sil demektir. işine göre kullanırsın.
#dropna(subset=['City','reported],how="all") hem şehirde hemde renkte null ise sil demektir.
#dropna(subset=['City','reported],how="any")  sadece biri null ise sil o veriyi.
print(data.shape)
