-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 06, 2020 at 08:18 PM
-- Server version: 10.4.16-MariaDB
-- PHP Version: 7.4.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hotelli`
--

-- --------------------------------------------------------

--
-- Table structure for table `asiakkaat`
--

CREATE TABLE `asiakkaat` (
  `AsiakasId` int(11) NOT NULL,
  `kayttajanimi` varchar(15) NOT NULL,
  `Etunimi` varchar(25) NOT NULL,
  `Sukunimi` varchar(35) NOT NULL,
  `Lahiosoite` varchar(50) NOT NULL,
  `Postinumero` varchar(10) NOT NULL,
  `Postitoimipaikka` varchar(25) NOT NULL,
  `Salasana` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `asiakkaat`
--

INSERT INTO `asiakkaat` (`AsiakasId`, `kayttajanimi`, `Etunimi`, `Sukunimi`, `Lahiosoite`, `Postinumero`, `Postitoimipaikka`, `Salasana`) VALUES
(1, 'antagent', 'Anton', 'Agentti', 'Piilokuja 34 a 11', '84210', 'Piilopirtti', '7qmKcsmh8yVsjDA+5AOF0A=='),
(2, 'jlindroos', 'Jyri', 'Lindroos', 'Keskikatu 3', '04200', 'Riihimäki', '7XC3nVsZ5MT2dQ3WDeWGSQ=='),
(3, 'sirlindr', 'Sirpa', 'Lindroos', 'Hallintokuja 33', '00520', 'Helsinki', 'uE8bxBrhYKEw0BQdz8mh7w=='),
(4, 'eeva.tervala', 'Eeva', 'Tervala', 'Keskikatu 3', '04200', 'Kerava', 'QWlnP9okKQsMD5MyFLlQXw==');

-- --------------------------------------------------------

--
-- Table structure for table `huoneet`
--

CREATE TABLE `huoneet` (
  `HuoneenNro` int(11) NOT NULL,
  `Huonetyyppi` int(11) DEFAULT NULL,
  `Puhelin` varchar(15) NOT NULL,
  `Vapaa` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `huoneet`
--

INSERT INTO `huoneet` (`HuoneenNro`, `Huonetyyppi`, `Puhelin`, `Vapaa`) VALUES
(101, 1, '101', 'Ei'),
(102, 1, '102', 'Kyllä'),
(103, 1, '103', 'Kyllä'),
(104, 1, '104', 'Kyllä'),
(111, 2, '111', 'Kyllä'),
(112, 2, '112', 'Kyllä'),
(113, 2, '113', 'Kyllä'),
(114, 2, '114', 'Kyllä'),
(121, 3, '121', 'Kyllä'),
(122, 3, '122', 'Kyllä'),
(431, 4, '431', 'Kyllä'),
(432, 4, '432', 'Kyllä');

-- --------------------------------------------------------

--
-- Table structure for table `huonekategoria`
--

CREATE TABLE `huonekategoria` (
  `KategoriaId` int(11) NOT NULL,
  `Huonetyyppi` varchar(15) NOT NULL,
  `Hinta` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `huonekategoria`
--

INSERT INTO `huonekategoria` (`KategoriaId`, `Huonetyyppi`, `Hinta`) VALUES
(1, 'Yhden hengen', '120'),
(2, 'Kahden hengen', '90'),
(3, 'Perhe', '150'),
(4, 'Sviitti', '300');

-- --------------------------------------------------------

--
-- Table structure for table `varaukset`
--

CREATE TABLE `varaukset` (
  `VarausId` int(11) NOT NULL,
  `HuoneenNro` int(11) NOT NULL,
  `AsiakasId` int(11) NOT NULL,
  `Sisaan` datetime NOT NULL,
  `Ulos` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `varaukset`
--

INSERT INTO `varaukset` (`VarausId`, `HuoneenNro`, `AsiakasId`, `Sisaan`, `Ulos`) VALUES
(8, 102, 2, '2020-12-06 00:00:00', '2020-12-09 00:00:00'),
(9, 103, 3, '2020-12-10 00:00:00', '2020-12-11 00:00:00'),
(10, 103, 3, '2020-12-10 00:00:00', '2020-12-11 00:00:00'),
(19, 101, 1, '2020-12-06 20:55:40', '2020-12-06 20:55:40'),
(20, 111, 2, '2020-12-31 00:00:00', '2021-01-01 00:00:00');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `asiakkaat`
--
ALTER TABLE `asiakkaat`
  ADD PRIMARY KEY (`AsiakasId`);

--
-- Indexes for table `huoneet`
--
ALTER TABLE `huoneet`
  ADD PRIMARY KEY (`HuoneenNro`),
  ADD KEY `Huonetyyppi` (`Huonetyyppi`);

--
-- Indexes for table `huonekategoria`
--
ALTER TABLE `huonekategoria`
  ADD PRIMARY KEY (`KategoriaId`);

--
-- Indexes for table `varaukset`
--
ALTER TABLE `varaukset`
  ADD PRIMARY KEY (`VarausId`),
  ADD KEY `fk_huone` (`HuoneenNro`),
  ADD KEY `AsiakasId` (`AsiakasId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `asiakkaat`
--
ALTER TABLE `asiakkaat`
  MODIFY `AsiakasId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `huonekategoria`
--
ALTER TABLE `huonekategoria`
  MODIFY `KategoriaId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `varaukset`
--
ALTER TABLE `varaukset`
  MODIFY `VarausId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `huoneet`
--
ALTER TABLE `huoneet`
  ADD CONSTRAINT `huoneet_ibfk_1` FOREIGN KEY (`Huonetyyppi`) REFERENCES `huonekategoria` (`kategoriaId`);

--
-- Constraints for table `varaukset`
--
ALTER TABLE `varaukset`
  ADD CONSTRAINT `fk_asiakas` FOREIGN KEY (`AsiakasId`) REFERENCES `asiakkaat` (`AsiakasId`),
  ADD CONSTRAINT `fk_huone` FOREIGN KEY (`HuoneenNro`) REFERENCES `huoneet` (`HuoneenNro`),
  ADD CONSTRAINT `varaukset_ibfk_1` FOREIGN KEY (`AsiakasId`) REFERENCES `asiakkaat` (`AsiakasId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
