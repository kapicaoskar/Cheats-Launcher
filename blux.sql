-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.4.20-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for allsql
CREATE DATABASE IF NOT EXISTS `allsql` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `allsql`;

-- Dumping structure for table allsql.bans
CREATE TABLE IF NOT EXISTS `bans` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `ip` varchar(255) NOT NULL,
  `hours` int(11) NOT NULL,
  `endTime` varchar(255) NOT NULL,
  `status` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4;

-- Data exporting was unselected.

-- Dumping structure for table allsql.blux_accounts
CREATE TABLE IF NOT EXISTS `blux_accounts` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `login` varchar(35) NOT NULL,
  `cpid` varchar(35) NOT NULL DEFAULT 'brak',
  `ranga` varchar(20) DEFAULT 'User',
  `token` varchar(30) NOT NULL,
  `token_email` varchar(35) NOT NULL,
  `email` varchar(45) NOT NULL,
  `weryfikacja` varchar(12) NOT NULL,
  `weryfikacja_data` varchar(25) NOT NULL,
  `haslo` varchar(200) NOT NULL,
  `ip_zalozenie` varchar(25) NOT NULL,
  `uzytyklucz` varchar(50) DEFAULT 'Test Version From Blux',
  `uzytyklucz2` varchar(50) DEFAULT 'nie',
  `uzytyklucz3` varchar(50) DEFAULT 'nie',
  `klucz_rust` varchar(50) DEFAULT 'nie',
  `klucz_cs` varchar(50) DEFAULT 'nie',
  `klucz_spoofer` varchar(50) DEFAULT 'nie',
  `klucz_fivem` varchar(50) DEFAULT 'nie',
  `klucz_fivem2` varchar(50) DEFAULT 'nie',
  `klucz_czas` varchar(50) DEFAULT 'Buy Key',
  `banned` varchar(50) DEFAULT 'nie',
  `bannedreason` varchar(50) DEFAULT 'brak',
  `pole1` varchar(50) DEFAULT 'nie',
  `linkpfp` mediumtext DEFAULT 'brak',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=1004 DEFAULT CHARSET=utf8mb4;

-- Data exporting was unselected.

-- Dumping structure for table allsql.categories
CREATE TABLE IF NOT EXISTS `categories` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `easier_id` varchar(255) NOT NULL,
  `name` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4;

-- Data exporting was unselected.

-- Dumping structure for table allsql.contact_forms
CREATE TABLE IF NOT EXISTS `contact_forms` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `email` varchar(255) NOT NULL,
  `topic` varchar(255) NOT NULL,
  `message` text NOT NULL,
  `date` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=106 DEFAULT CHARSET=utf8mb4;

-- Data exporting was unselected.

-- Dumping structure for table allsql.informations
CREATE TABLE IF NOT EXISTS `informations` (
  `id` int(3) NOT NULL AUTO_INCREMENT,
  `linksponsor` mediumtext DEFAULT 'brak',
  `linksponsor2` mediumtext DEFAULT 'brak',
  `linksponsor3` mediumtext DEFAULT 'brak',
  `linksponsor4` mediumtext DEFAULT 'brak',
  `pfpreseller` mediumtext DEFAULT 'brak',
  `pfpreseller2` mediumtext DEFAULT 'brak',
  `pfpreseller3` mediumtext DEFAULT 'brak',
  `pfpreseller4` mediumtext DEFAULT 'brak',
  `pfpreseller5` mediumtext DEFAULT 'brak',
  `sponsor` varchar(50) DEFAULT 'Brak',
  `sponsor2` varchar(50) DEFAULT 'Brak',
  `sponsor3` varchar(50) DEFAULT 'Brak',
  `sponsor4` varchar(50) DEFAULT 'Brak',
  `updatelauncher` varchar(50) DEFAULT 'nie',
  `nickreseller` varchar(50) DEFAULT 'brak',
  `nickreseller2` varchar(50) DEFAULT 'brak',
  `nickreseller3` varchar(50) DEFAULT 'brak',
  `nickreseller4` varchar(50) DEFAULT 'brak',
  `nickreseller5` varchar(50) DEFAULT 'brak',
  `sponsorweb` varchar(50) DEFAULT 'brak',
  `sponsorweb2` varchar(50) DEFAULT 'brak',
  `sponsorweb3` varchar(50) DEFAULT 'brak',
  `sponsorweb4` varchar(50) DEFAULT 'brak',
  `textworking` varchar(50) DEFAULT 'brak',
  `textworking2` varchar(50) DEFAULT 'brak',
  `textworking3` varchar(50) DEFAULT 'brak',
  `textworking4` varchar(50) DEFAULT 'brak',
  `textworking5` varchar(50) NOT NULL DEFAULT 'brak',
  `textworking6` varchar(50) DEFAULT 'brak',
  `tojuzkoniec` varchar(50) DEFAULT 'nie',
  `fivem3` varchar(50) DEFAULT 'nie',
  `cs2` varchar(50) DEFAULT 'nie',
  `spooferwork` varchar(50) DEFAULT 'nie',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

-- Data exporting was unselected.

-- Dumping structure for table allsql.keyauth
CREATE TABLE IF NOT EXISTS `keyauth` (
  `key` varchar(100) DEFAULT 'pusty',
  `game` varchar(25) DEFAULT 'brak',
  `time` varchar(50) DEFAULT '0',
  `reason` varchar(50) DEFAULT 'brak',
  `creator` varchar(50) DEFAULT 'brak',
  `used` varchar(50) DEFAULT 'nie',
  `owner` varchar(50) DEFAULT 'brak'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Data exporting was unselected.

-- Dumping structure for table allsql.products
CREATE TABLE IF NOT EXISTS `products` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `category_id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `ppo` float NOT NULL,
  `minQuantity` int(11) NOT NULL,
  `maxQuantity` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4;

-- Data exporting was unselected.

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
