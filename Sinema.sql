CREATE DATABASE Sinema

USE Sinema
GO

CREATE TABLE [Filmler] (
  [FilmId] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [Tur] nvarchar(50) NOT NULL,
  [FilmAd] nvarchar(50) UNIQUE NOT NULL,
  [Konu] nvarchar(MAX) NOT NULL,
  [Yonetmen] nvarchar(50),
  [Basrol] nvarchar(MAX),
  [Senarist] nvarchar(50),
  [Dil] nvarchar(50),
  [VizyonTarihi] datetime,
  [Sure] nvarchar(50),
  [YetiskinlikDuzeyi] nvarchar(MAX),
  [IMDb] nvarchar(50)
)
GO

CREATE TABLE [Salonlar] (
  [SalonId] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [SalonAd] nvarchar(50) NOT NULL,
  [SalonFormat] nvarchar(50),
  [FilmSeans] nvarchar(50) NOT NULL,
  [FilmTur] nvarchar(50), 
  [FilmAd] nvarchar(50), 
  [Sure] nvarchar(50),
  [FilmFormat] nvarchar(50),
  [DilFormat] nvarchar(50)
)
GO

CREATE TABLE [Biletler] (
  [BiletId] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [Tarih] datetime,
  [MusteriAdSoyad] nvarchar(50),
  [MusteriTur] nvarchar(50),
  [SalonAd] nvarchar(50),
  [SalonFormat] nvarchar(50),
  [FilmSeans] nvarchar(50),
  [KoltukNo] nvarchar(50),
  [FilmAd] nvarchar(50),
  [Sure] nvarchar(50),
  [FilmFormat] nvarchar(50),
  [DilFormat] nvarchar(50),
  [EkBilgiler] nvarchar(50)
)
GO

CREATE TABLE [Personeller] (
  [PersonelId] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [KullaniciAd] nvarchar(50) UNIQUE NOT NULL,
  [Sifre] nvarchar(50),
  [AdSoyad] nvarchar(50),
  [DogumGunu] datetime,
  [Mail] nvarchar(50),
  [Gsm] nvarchar(50),
  [Adres] nvarchar(50),
  [CV] nvarchar(50)
)
GO

CREATE TABLE [SalonA] (
  [SalonId] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [Tarih] datetime,
  [SeansNo] nvarchar(50),
  [A1] nvarchar(50),
  [A2] nvarchar(50),
  [A3] nvarchar(50),
  [A4] nvarchar(50),
  [A5] nvarchar(50),
  [B1] nvarchar(50),
  [B2] nvarchar(50),
  [B3] nvarchar(50),
  [B4] nvarchar(50),
  [B5] nvarchar(50),
  [C1] nvarchar(50),
  [C2] nvarchar(50),
  [C3] nvarchar(50),
  [C4] nvarchar(50),
  [C5] nvarchar(50)
)
GO

CREATE TABLE [SalonB] (
  [SalonId] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [Tarih] datetime,
  [SeansNo] nvarchar(50),
  [A1] nvarchar(50),
  [A2] nvarchar(50),
  [A3] nvarchar(50),
  [A4] nvarchar(50),
  [A5] nvarchar(50),
  [B1] nvarchar(50),
  [B2] nvarchar(50),
  [B3] nvarchar(50),
  [B4] nvarchar(50),
  [B5] nvarchar(50),
  [C1] nvarchar(50),
  [C2] nvarchar(50),
  [C3] nvarchar(50),
  [C4] nvarchar(50),
  [C5] nvarchar(50)
)
GO

CREATE TABLE [SalonC] (
  [SalonId] int PRIMARY KEY NOT NULL IDENTITY(1, 1),
  [Tarih] datetime,
  [SeansNo] nvarchar(50),
  [A1] nvarchar(50),
  [A2] nvarchar(50),
  [A3] nvarchar(50),
  [A4] nvarchar(50),
  [A5] nvarchar(50),
  [B1] nvarchar(50),
  [B2] nvarchar(50),
  [B3] nvarchar(50),
  [B4] nvarchar(50),
  [B5] nvarchar(50),
  [C1] nvarchar(50),
  [C2] nvarchar(50),
  [C3] nvarchar(50),
  [C4] nvarchar(50),
  [C5] nvarchar(50)
)
GO

ALTER TABLE [Salonlar] ADD FOREIGN KEY ([FilmAd]) REFERENCES [Filmler] ([FilmAd])
GO

ALTER TABLE [Biletler] ADD FOREIGN KEY ([FilmAd]) REFERENCES [Filmler] ([FilmAd])
GO

INSERT INTO [dbo].[Personeller] ([KullaniciAd],[Sifre],[AdSoyad],[DogumGunu],[Mail],[Gsm],[Adres],[CV]) VALUES ('papatya','123','Merve SANCAK','1986-05-08','mervesancak@gmail.com' ,'05528659452','xxx','yyy') 
GO

INSERT INTO [dbo].[Filmler] ([Tur],[FilmAd],[Konu],[Yonetmen],[Basrol],[Senarist],[Dil],[VizyonTarihi],[Sure],[YetiskinlikDuzeyi],[IMDb]) VALUES ('Aksiyon','The Old Guard','Yuzyillar boyunca gizlice insanligi koruyan dort olumsuz savasci, yeni bir olumsuzu kesfettikleri sirada gizemli gucleri nedeniyle hedef haline gelir','Gina Prince-Bythewood','Charlize Theron - KiKi Layne - Matthias Schoenaerts','Greg Rucka','Ingilizce','2020-07-10','2sa 5dk','18+ Siddet-Argo','6.6')          
GO

INSERT INTO [dbo].[Filmler] ([Tur],[FilmAd],[Konu],[Yonetmen],[Basrol],[Senarist],[Dil],[VizyonTarihi],[Sure],[YetiskinlikDuzeyi],[IMDb]) VALUES ('Drama Gerilim','Do not Tell a Soul','Hasta annelerine yardim etmek icin para calan iki hirsiz genc erkek kardes, unutulmus bir kuyunun dibine sikismis sorunlu bir güvenlik görevlisi ile akil yurutur','Alex McAulay',' Fionn Whitehead - Jack Dylan Grazer - Mena Suvari',' Alex McAulay','Ingilizce','2021-01-15','1sa 23dk','18+','7.9')          
GO

INSERT INTO [dbo].[Salonlar] ([SalonAd],[SalonFormat],[FilmSeans],[FilmTur],[FilmAd],[Sure],[FilmFormat],[DilFormat]) VALUES ('Salon A','Normal','Cuma 21:00-23:05','Aksiyon','The Old Guard','2sa 5dk','2D','Turkce Altyazili')
GO

INSERT INTO [dbo].[Salonlar] ([SalonAd],[SalonFormat],[FilmSeans],[FilmTur],[FilmAd],[Sure],[FilmFormat],[DilFormat]) VALUES ('Salon B','Normal','Cuma 21:00-22:23','Drama Gerilim','Do not Tell a Soul','1sa 23dk','2D','Turkce Altyazili')
GO

INSERT INTO [dbo].[Salonlar] ([SalonAd],[SalonFormat],[FilmSeans],[FilmTur],[FilmAd],[Sure],[FilmFormat],[DilFormat]) VALUES ('Salon C','IMAX','Cuma 21:00-22:23','Drama Gerilim','Do not Tell a Soul','1sa 23dk','IMAX','Turkce Altyazili')
GO


INSERT INTO [dbo].[SalonA] ([Tarih],[SeansNo],[A1],[A2],[A3],[A4],[A5],[B1],[B2],[B3],[B4],[B5],[C1],[C2],[C3],[C4],[C5]) VALUES ('2021-01-15','Seans 4 (21:00-01:00)','Bos','Bos','Bos','Bos','Bos','Bos','Bos','Bos','Bos','Bos','Bos','Bos','Bos','Bos','Bos')
GO

INSERT INTO [dbo].[SalonB] ([Tarih],[SeansNo],[A1],[A2],[A3],[A4],[A5],[B1],[B2],[B3],[B4],[B5],[C1],[C2],[C3],[C4],[C5]) VALUES ('2021-01-15','Seans 4 (21:00-01:00)','Bos','Bos','Bos','Bos','Bos','Bos','Bos','Bos','Bos','Bos','Bos','Bos','Bos','Bos','Bos')
GO

INSERT INTO [dbo].[SalonC] ([Tarih],[SeansNo],[A1],[A2],[A3],[A4],[A5],[B1],[B2],[B3],[B4],[B5],[C1],[C2],[C3],[C4],[C5]) VALUES ('2021-01-15','Seans 4 (21:00-01:00)','Bos','Bos','Bos','Bos','Bos','Bos','Bos','Bos','Bos','Bos','Bos','Bos','Bos','Bos','Bos')
GO


