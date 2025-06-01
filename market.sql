CREATE DATABASE supermarket_otomasyonu;
USE supermarket_otomasyonu;

CREATE TABLE kullanicilar (
    id INT AUTO_INCREMENT PRIMARY KEY,
    ad VARCHAR(50),
    soyad VARCHAR(50),
    kullanici_adi VARCHAR(50) UNIQUE,
    sifre VARCHAR(100),
    rol ENUM('Yonetici', 'Personel') NOT NULL
);

CREATE TABLE urunler (
    id INT AUTO_INCREMENT PRIMARY KEY,
    barkod_no VARCHAR(20) UNIQUE,
    urun_adi VARCHAR(100),
    kategori VARCHAR(50),
    fiyat DECIMAL(10,2),
    stok INT,
    alt_limit INT
);

CREATE TABLE satislar (
    id INT AUTO_INCREMENT PRIMARY KEY,
    urun_id INT,
    miktar INT,
    toplam_fiyat DECIMAL(10,2),
    tarih DATETIME,
    satis_yapan VARCHAR(50),
    FOREIGN KEY (urun_id) REFERENCES urunler(id)
);

CREATE TABLE kategori (
    id INT AUTO_INCREMENT PRIMARY KEY,
    kategori_adi VARCHAR(50) UNIQUE
);

CREATE TABLE loglar (
    id INT AUTO_INCREMENT PRIMARY KEY,
    kullanici_adi VARCHAR(50),
    islem_aciklamasi TEXT,
    tarih DATETIME
);
