-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1:3306
-- Üretim Zamanı: 03 Oca 2023, 17:40:06
-- Sunucu sürümü: 5.7.36
-- PHP Sürümü: 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `school_management_sys`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `branches`
--

DROP TABLE IF EXISTS `branches`;
CREATE TABLE IF NOT EXISTS `branches` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `branches`
--

INSERT INTO `branches` (`ID`, `name`) VALUES
(9, 'Rehberlik '),
(10, 'Beden Eğitimi'),
(11, 'Matematik'),
(12, 'Türk Dili Edebiyatı'),
(13, 'Biyoloji'),
(14, 'İngilizce'),
(15, 'Almanca'),
(16, 'Fizik'),
(17, 'Görsel sanatlar'),
(18, 'Kimya');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `lessons`
--

DROP TABLE IF EXISTS `lessons`;
CREATE TABLE IF NOT EXISTS `lessons` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`),
  KEY `name` (`name`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `lessons`
--

INSERT INTO `lessons` (`ID`, `name`) VALUES
(15, 'Almanca'),
(10, 'Beden Eğitimi'),
(13, 'Biyoloji'),
(16, 'Fizik'),
(17, 'Görsel sanatlar'),
(14, 'İngilizce'),
(18, 'Kimya'),
(11, 'Matematik'),
(9, 'Rehberlik '),
(12, 'Türk Dili Edebiyatı');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `lessonslearns`
--

DROP TABLE IF EXISTS `lessonslearns`;
CREATE TABLE IF NOT EXISTS `lessonslearns` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `lessonid` int(11) NOT NULL,
  `studentid` int(11) NOT NULL,
  `lessonname` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL,
  `exam1` int(11) DEFAULT NULL,
  `exam2` int(11) DEFAULT NULL,
  `avg` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `lessonid` (`lessonid`,`studentid`),
  KEY `studentid` (`studentid`),
  KEY `lessonname` (`lessonname`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `lessonslearns`
--

INSERT INTO `lessonslearns` (`ID`, `lessonid`, `studentid`, `lessonname`, `exam1`, `exam2`, `avg`) VALUES
(12, 9, 1, 'Rehberlik ', 32, 40, 50),
(13, 10, 1, 'Beden Eğitimi', 80, 80, 80),
(14, 11, 1, 'Matematik', 45, 55, 77);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `lessonstaughts`
--

DROP TABLE IF EXISTS `lessonstaughts`;
CREATE TABLE IF NOT EXISTS `lessonstaughts` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `lessonid` int(11) NOT NULL,
  `teacherid` int(11) NOT NULL,
  `lessonname` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL,
  `teachername` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `lessonid` (`lessonid`,`teacherid`),
  KEY `teacherid` (`teacherid`),
  KEY `lessonname` (`lessonname`,`teachername`),
  KEY `teachername` (`teachername`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `parents`
--

DROP TABLE IF EXISTS `parents`;
CREATE TABLE IF NOT EXISTS `parents` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) COLLATE utf8mb4_turkish_ci NOT NULL,
  `phone_number` varchar(11) COLLATE utf8mb4_turkish_ci NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `parents`
--

INSERT INTO `parents` (`ID`, `name`, `phone_number`) VALUES
(1, 'Katheryn Elizabeth Hudson', '55555'),
(2, 'MehmetArslan', '05554443322'),
(3, 'Ferman Akgül', '05554443322'),
(4, 'Yağmur Sarıgül', '05554443322'),
(5, 'Fatih Artman', '05554443322'),
(6, 'Sertab Erener', '05554443322'),
(7, 'Özgür Can Öney', '05554443322'),
(8, 'Buğra Arkın', '05554443322'),
(9, 'Özgür Eker', '05554443322'),
(10, 'Alp Mete Türkoğlu', '05554443322'),
(11, 'Murat Sarı', '05554443322'),
(12, 'Veli', '12341234131');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `students`
--

DROP TABLE IF EXISTS `students`;
CREATE TABLE IF NOT EXISTS `students` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `name` mediumtext COLLATE utf8mb4_turkish_ci NOT NULL,
  `phonenumber` mediumtext COLLATE utf8mb4_turkish_ci NOT NULL,
  `mail` mediumtext COLLATE utf8mb4_turkish_ci NOT NULL,
  `password` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL,
  `gender` varchar(15) COLLATE utf8mb4_turkish_ci NOT NULL,
  `dateofbirth` date NOT NULL,
  `adress` varchar(500) COLLATE utf8mb4_turkish_ci NOT NULL,
  `parent_id` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `parent_id` (`parent_id`),
  KEY `ID` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `students`
--

INSERT INTO `students` (`ID`, `name`, `phonenumber`, `mail`, `password`, `gender`, `dateofbirth`, `adress`, `parent_id`) VALUES
(1, 'muharrem tekin', '123123', 'test@test.com', '1234', 'male', '2022-08-09', 'falan filan falan filan', 4),
(2, 'Ahmet leleley', '05554443322', 'ahmet123@gmail.com', '1234', 'male', '2008-12-05', 'falan filan falan filan', 1),
(4, 'Fevzi Çakmak', '1923', 'fevzicakmak@tbmm.com', '1234', 'Erkek', '1876-01-12', '', 10),
(5, 'Ahmet Ahmetoglu', '05554443322', 'ahmet123@gmail.com', '1234', 'Mage assasin', '2008-12-05', 'qweqweqweqwewq', 5),
(7, 'Seyma Nur DOGAN', '123123123123', 'fevzicakmak@tbmm.com', '12345', 'Kadin', '2001-10-27', 'konya', 6);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `teachers`
--

DROP TABLE IF EXISTS `teachers`;
CREATE TABLE IF NOT EXISTS `teachers` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL,
  `phone_number` varchar(11) COLLATE utf8mb4_turkish_ci NOT NULL,
  `mail` varchar(255) COLLATE utf8mb4_turkish_ci NOT NULL,
  `password` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL,
  `gender` varchar(6) COLLATE utf8mb4_turkish_ci NOT NULL,
  `date_of_birth` date NOT NULL,
  `adress` varchar(500) COLLATE utf8mb4_turkish_ci NOT NULL,
  `branchID` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`),
  KEY `branchID` (`branchID`),
  KEY `name` (`name`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `teachers`
--

INSERT INTO `teachers` (`ID`, `name`, `phone_number`, `mail`, `password`, `gender`, `date_of_birth`, `adress`, `branchID`) VALUES
(1, 'Betül Çetinn', '05554443322', 'betulcetin@gmail.com', '1234', 'Kadin', '1985-12-26', 'ww eeeee rrrrrr', 10),
(3, 'Ümit Fatih Özkan', '3232323232', 'ufö@gmail.com', '1234', 'Erkek', '1990-06-15', 'update test 2', 16);

--
-- Dökümü yapılmış tablolar için kısıtlamalar
--

--
-- Tablo kısıtlamaları `lessonslearns`
--
ALTER TABLE `lessonslearns`
  ADD CONSTRAINT `lessonslearns_ibfk_2` FOREIGN KEY (`studentid`) REFERENCES `students` (`ID`),
  ADD CONSTRAINT `lessonslearns_ibfk_3` FOREIGN KEY (`lessonid`) REFERENCES `lessons` (`ID`),
  ADD CONSTRAINT `lessonslearns_ibfk_4` FOREIGN KEY (`lessonname`) REFERENCES `lessons` (`name`);

--
-- Tablo kısıtlamaları `lessonstaughts`
--
ALTER TABLE `lessonstaughts`
  ADD CONSTRAINT `lessonstaughts_ibfk_1` FOREIGN KEY (`teacherid`) REFERENCES `teachers` (`ID`),
  ADD CONSTRAINT `lessonstaughts_ibfk_2` FOREIGN KEY (`lessonid`) REFERENCES `lessons` (`ID`),
  ADD CONSTRAINT `lessonstaughts_ibfk_3` FOREIGN KEY (`teachername`) REFERENCES `teachers` (`name`),
  ADD CONSTRAINT `lessonstaughts_ibfk_4` FOREIGN KEY (`lessonname`) REFERENCES `lessons` (`name`);

--
-- Tablo kısıtlamaları `students`
--
ALTER TABLE `students`
  ADD CONSTRAINT `students_ibfk_1` FOREIGN KEY (`parent_id`) REFERENCES `parents` (`ID`);

--
-- Tablo kısıtlamaları `teachers`
--
ALTER TABLE `teachers`
  ADD CONSTRAINT `teachers_ibfk_1` FOREIGN KEY (`branchID`) REFERENCES `branches` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
