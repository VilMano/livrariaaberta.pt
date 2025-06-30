/*M!999999\- enable the sandbox mode */
-- MariaDB dump 10.19-11.2.6-MariaDB, for debian-linux-gnu (x86_64)
--
-- Host: localhost    Database: Aberta
-- ------------------------------------------------------
-- Server version	11.2.6-MariaDB-ubu2204

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Current Database: `Aberta`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `Aberta` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;

USE `Aberta`;

--
-- Table structure for table `BookTag`
--

DROP TABLE IF EXISTS `BookTag`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `BookTag` (
                           `BooksId` varchar(255) NOT NULL,
                           `TagsListId` int(11) NOT NULL,
                           PRIMARY KEY (`BooksId`,`TagsListId`),
                           KEY `IX_BookTag_TagsListId` (`TagsListId`),
                           CONSTRAINT `FK_BookTag_Books_BooksId` FOREIGN KEY (`BooksId`) REFERENCES `Books` (`Id`) ON DELETE CASCADE,
                           CONSTRAINT `FK_BookTag_Tags_TagsListId` FOREIGN KEY (`TagsListId`) REFERENCES `Tags` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `BookTag`
--

LOCK TABLES `BookTag` WRITE;
/*!40000 ALTER TABLE `BookTag` DISABLE KEYS */;
/*!40000 ALTER TABLE `BookTag` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Books`
--

DROP TABLE IF EXISTS `Books`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Books` (
                         `Id` varchar(255) NOT NULL,
                         `Isbn` longtext DEFAULT NULL,
                         `Title` longtext DEFAULT NULL,
                         `Stock` int(11) NOT NULL,
                         `Publisher` longtext DEFAULT NULL,
                         `CoverPicture` longtext DEFAULT NULL,
                         `Synopsis` longtext DEFAULT NULL,
                         `Price` float NOT NULL,
                         `Author` longtext DEFAULT NULL,
                         `Language` longtext DEFAULT NULL,
                         `ReleaseDate` longtext DEFAULT NULL,
                         `IsActive` tinyint(1) NOT NULL DEFAULT 0,
                         `Translator` longtext DEFAULT NULL,
                         PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Books`
--

LOCK TABLES `Books` WRITE;
/*!40000 ALTER TABLE `Books` DISABLE KEYS */;
/*!40000 ALTER TABLE `Books` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Tags`
--

DROP TABLE IF EXISTS `Tags`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Tags` (
                        `Id` int(11) NOT NULL AUTO_INCREMENT,
                        `Name` longtext NOT NULL,
                        `IsActive` tinyint(1) NOT NULL,
                        PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Tags`
--

LOCK TABLES `Tags` WRITE;
/*!40000 ALTER TABLE `Tags` DISABLE KEYS */;
/*!40000 ALTER TABLE `Tags` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `__EFMigrationsHistory`
--

DROP TABLE IF EXISTS `__EFMigrationsHistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `__EFMigrationsHistory` (
                                         `MigrationId` varchar(150) NOT NULL,
                                         `ProductVersion` varchar(32) NOT NULL,
                                         PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__EFMigrationsHistory`
--

LOCK TABLES `__EFMigrationsHistory` WRITE;
/*!40000 ALTER TABLE `__EFMigrationsHistory` DISABLE KEYS */;
INSERT INTO `__EFMigrationsHistory` VALUES
                                        ('20241006003151_InitialMigration','8.0.8'),
                                        ('20241105194316_seedBooks','8.0.8'),
                                        ('20241127155524_AddNewFieldsToBook','8.0.8'),
                                        ('20241203221332_AddedTags','8.0.8'),
                                        ('20250208221149_AddTranslator','8.0.8'),
                                        ('20250209120520_FixModels','8.0.8');
/*!40000 ALTER TABLE `__EFMigrationsHistory` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-02-09 20:53:45
