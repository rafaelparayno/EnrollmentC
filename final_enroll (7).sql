-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 28, 2020 at 09:48 AM
-- Server version: 10.1.38-MariaDB
-- PHP Version: 7.3.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `final_enroll`
--

-- --------------------------------------------------------

--
-- Table structure for table `audit_trail`
--

CREATE TABLE `audit_trail` (
  `audit_id` int(11) NOT NULL,
  `date_time` varchar(50) DEFAULT NULL,
  `user` text NOT NULL,
  `action` text NOT NULL,
  `user_type` text NOT NULL,
  `username` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `audit_trail`
--

INSERT INTO `audit_trail` (`audit_id`, `date_time`, `user`, `action`, `user_type`, `username`) VALUES
(1, '08/09/2020  10:30:57 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'B.Khristine Joy'),
(2, '08/09/2020  10:31:12 PM', 'Khristine Guinto Badiana', 'B.Khristine JoyHas Logged-out', 'System Admin', 'B.Khristine Joy'),
(3, '08/09/2020  10:31:22 PM', 'Elizabeth Tapic Sombilon', 'User has been Login', 'Enrollment Admin', 'S.Elizabeth'),
(4, '08/10/2020  04:19:20 PM', 'Elizabeth Tapic Sombilon', 'User has been Login', 'Enrollment Admin', 'S.Elizabeth'),
(5, '08/10/2020  05:27:21 PM', 'Elizabeth Tapic Sombilon', 'S.ElizabethHas Logged-out', 'Enrollment Admin', 'S.Elizabeth'),
(6, '08/10/2020  05:27:48 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'B.Khristine Joy'),
(7, '08/10/2020  05:28:07 PM', 'Khristine Guinto Badiana', 'B.Khristine JoyHas Logged-out', 'System Admin', 'B.Khristine Joy'),
(8, '08/10/2020  05:28:18 PM', 'Elizabeth Tapic Sombilon', 'User has been Login', 'Enrollment Admin', 'S.Elizabeth'),
(9, '08/10/2020  05:34:00 PM', 'Elizabeth Tapic Sombilon', 'S.ElizabethHas Logged-out', 'Enrollment Admin', 'S.Elizabeth'),
(10, '08/10/2020  05:34:14 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'B.Khristine Joy'),
(11, '08/10/2020  05:34:27 PM', 'Khristine Guinto Badiana', 'B.Khristine JoyHas Logged-out', 'System Admin', 'B.Khristine Joy'),
(12, '08/10/2020  05:35:26 PM', 'Elizabeth Tapic Sombilon', 'User has been Login', 'Enrollment Admin', 'S.Elizabeth'),
(13, '08/10/2020  05:53:59 PM', 'Elizabeth Tapic Sombilon', 'S.ElizabethHas Logged-out', 'Enrollment Admin', 'S.Elizabeth'),
(14, '08/10/2020  05:54:12 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'B.Khristine Joy'),
(15, '08/10/2020  05:54:20 PM', 'Khristine Guinto Badiana', 'B.Khristine JoyHas Logged-out', 'System Admin', 'B.Khristine Joy'),
(16, '08/10/2020  05:55:31 PM', 'Elizabeth Tapic Sombilon', 'User has been Login', 'Enrollment Admin', 'S.Elizabeth'),
(17, '08/10/2020  07:13:02 PM', 'Elizabeth Tapic Sombilon', 'S.ElizabethHas Logged-out', 'Enrollment Admin', 'S.Elizabeth'),
(18, '08/10/2020  07:22:03 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'B.Khristine Joy'),
(19, '08/10/2020  07:22:51 PM', 'Khristine Guinto Badiana', 'B.Khristine JoyHas Logged-out', 'System Admin', 'B.Khristine Joy'),
(20, '08/10/2020  07:23:13 PM', 'Elizabeth Tapic Sombilon', 'User has been Login', 'Enrollment Admin', 'S.Elizabeth'),
(21, '08/10/2020  08:31:19 PM', 'Elizabeth Tapic Sombilon', 'User has been Login', 'Enrollment Admin', 'S.Elizabeth'),
(22, '08/10/2020  08:37:14 PM', 'Elizabeth Tapic Sombilon', 'S.ElizabethHas Logged-out', 'Enrollment Admin', 'S.Elizabeth'),
(23, '08/10/2020  08:38:05 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'B.Khristine Joy'),
(24, '08/10/2020  08:38:16 PM', 'Khristine Guinto Badiana', 'B.Khristine JoyHas Logged-out', 'System Admin', 'B.Khristine Joy'),
(25, '08/10/2020  08:38:23 PM', 'Elizabeth Tapic Sombilon', 'User has been Login', 'Enrollment Admin', 'S.Elizabeth'),
(26, '08/10/2020  09:20:25 PM', 'Elizabeth Tapic Sombilon', 'User has been Login', 'Enrollment Admin', 'S.Elizabeth'),
(27, '08/10/2020  09:21:10 PM', 'Elizabeth Tapic Sombilon', 'S.ElizabethHas Logged-out', 'Enrollment Admin', 'S.Elizabeth'),
(28, '08/10/2020  09:23:45 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'B.Khristine Joy'),
(29, '08/10/2020  09:23:54 PM', 'Khristine Guinto Badiana', 'B.Khristine JoyHas Logged-out', 'System Admin', 'B.Khristine Joy'),
(30, '08/10/2020  09:24:12 PM', 'Elizabeth Tapic Sombilon', 'User has been Login', 'Enrollment Admin', 'S.Elizabeth'),
(31, '08/10/2020  09:38:08 PM', 'Elizabeth Tapic Sombilon', 'User has been Login', 'Enrollment Admin', 'S.Elizabeth'),
(32, '08/10/2020  09:48:00 PM', 'Elizabeth Tapic Sombilon', 'User has been Login', 'Enrollment Admin', 'S.Elizabeth'),
(33, '08/10/2020  10:03:25 PM', 'Elizabeth Tapic Sombilon', 'User has been Login', 'Enrollment Admin', 'S.Elizabeth'),
(34, '08/10/2020  10:08:37 PM', 'Elizabeth Tapic Sombilon', 'User has been Login', 'Enrollment Admin', 'S.Elizabeth'),
(35, '08/10/2020  10:14:35 PM', 'Elizabeth Tapic Sombilon', 'User has been Login', 'Enrollment Admin', 'S.Elizabeth'),
(36, '08/10/2020  10:14:45 PM', 'Elizabeth Tapic Sombilon', 'S.ElizabethHas Logged-out', 'Enrollment Admin', 'S.Elizabeth'),
(37, '08/10/2020  10:16:07 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(38, '08/10/2020  10:46:25 PM', 'Elizabeth Tapic Sombilon', 'User has been Login', 'Enrollment Admin', 'S.Elizabeth'),
(39, '08/11/2020  12:54:32 AM', 'Elizabeth Tapic Sombilon', 'S.ElizabethHas Logged-out', 'Enrollment Admin', 'S.Elizabeth'),
(40, '08/11/2020  12:55:32 AM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'B.Khristine Joy'),
(41, '08/11/2020  12:56:19 AM', 'Khristine Guinto Badiana', 'B.Khristine JoyHas Logged-out', 'System Admin', 'B.Khristine Joy'),
(42, '08/11/2020  12:56:30 AM', 'Elizabeth Tapic Sombilon', 'User has been Login', 'Enrollment Admin', 'S.Elizabeth'),
(43, '08/11/2020  01:09:01 AM', 'Elizabeth Tapic Sombilon', 'S.ElizabethHas Logged-out', 'Enrollment Admin', 'S.Elizabeth'),
(44, '08/11/2020  03:14:13 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'B.Khristine Joy'),
(45, '08/11/2020  03:14:28 PM', 'Khristine Guinto Badiana', 'B.Khristine JoyHas Logged-out', 'System Admin', 'B.Khristine Joy'),
(46, '08/11/2020  03:14:45 PM', 'Elizabeth Tapic Sombilon', 'User has been Login', 'Enrollment Admin', 'S.Elizabeth'),
(47, '08/11/2020  03:26:53 PM', 'Elizabeth Tapic Sombilon', 'S.ElizabethHas Logged-out', 'Enrollment Admin', 'S.Elizabeth'),
(48, '08/11/2020  03:27:07 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'B.Khristine Joy'),
(49, '08/11/2020  03:27:29 PM', 'Khristine Guinto Badiana', 'B.Khristine JoyHas Logged-out', 'System Admin', 'B.Khristine Joy'),
(50, '08/11/2020  03:27:38 PM', 'Elizabeth Tapic Sombilon', 'User has been Login', 'Enrollment Admin', 'S.Elizabeth'),
(51, '08/11/2020  04:53:15 PM', 'Elizabeth Tapic Sombilon', 'User has been Login', 'Enrollment Admin', 'S.Elizabeth'),
(52, '08/11/2020  05:15:10 PM', 'Elizabeth Tapic Sombilon', 'User has been Login', 'Enrollment Admin', 'S.Elizabeth'),
(53, '08/11/2020  05:53:31 PM', 'Elizabeth Tapic Sombilon', 'S.ElizabethHas Logged-out', 'Enrollment Admin', 'S.Elizabeth'),
(54, '08/11/2020  05:53:49 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'B.Khristine Joy'),
(55, '08/11/2020  05:54:07 PM', 'Khristine Guinto Badiana', 'B.Khristine JoyHas Logged-out', 'System Admin', 'B.Khristine Joy'),
(56, '08/11/2020  05:54:41 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(57, '08/11/2020  05:55:46 PM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(58, '08/11/2020  05:55:58 PM', 'Elizabeth Tapic Sombilon', 'User has been Login', 'Enrollment Admin', 'S.Elizabeth'),
(59, '08/11/2020  05:56:18 PM', 'Elizabeth Tapic Sombilon', 'S.ElizabethHas Logged-out', 'Enrollment Admin', 'S.Elizabeth'),
(60, '08/11/2020  05:56:32 PM', 'Elizabeth Tapic Sombilon', 'User has been Login', 'Enrollment Admin', 'S.Elizabeth'),
(61, '08/11/2020  05:56:38 PM', 'Elizabeth Tapic Sombilon', 'S.ElizabethHas Logged-out', 'Enrollment Admin', 'S.Elizabeth'),
(62, '08/11/2020  05:56:58 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'B.Khristine Joy'),
(63, '08/11/2020  05:57:06 PM', 'Khristine Guinto Badiana', 'B.Khristine JoyHas Logged-out', 'System Admin', 'B.Khristine Joy'),
(64, '08/11/2020  05:57:55 PM', 'Elizabeth Tapic Sombilon', 'User has been Login', 'Enrollment Admin', 'S.Elizabeth'),
(65, '08/11/2020  07:15:08 PM', 'Elizabeth Tapic Sombilon', 'S.ElizabethHas Logged-out', 'Enrollment Admin', 'S.Elizabeth'),
(66, '08/11/2020  08:52:46 PM', 'Elizabeth Tapic Sombilon', 'User has been Login', 'Enrollment Admin', 'S.Elizabeth'),
(67, '08/11/2020  10:00:15 PM', 'Elizabeth Tapic Sombilon', 'S.ElizabethHas Logged-out', 'Enrollment Admin', 'S.Elizabeth'),
(68, '08/11/2020  10:00:29 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'B.Khristine Joy'),
(69, '08/11/2020  10:00:43 PM', 'Khristine Guinto Badiana', 'B.Khristine JoyHas Logged-out', 'System Admin', 'B.Khristine Joy'),
(70, '08/11/2020  10:00:52 PM', 'Elizabeth Tapic Sombilon', 'User has been Login', 'Enrollment Admin', 'S.Elizabeth'),
(71, '08/11/2020  10:30:20 PM', 'Elizabeth Tapic Sombilon', 'User has been Login', 'Enrollment Admin', 'S.Elizabeth'),
(72, '08/11/2020  11:13:45 PM', 'Elizabeth Tapic Sombilon', 'User has been Login', 'Enrollment Admin', 'S.Elizabeth'),
(73, '08/11/2020  11:29:14 PM', 'Elizabeth Tapic Sombilon', 'S.ElizabethHas Logged-out', 'Enrollment Admin', 'S.Elizabeth'),
(74, '08/11/2020  11:29:25 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'B.Khristine Joy'),
(75, '08/11/2020  11:29:34 PM', 'Khristine Guinto Badiana', 'B.Khristine JoyHas Logged-out', 'System Admin', 'B.Khristine Joy'),
(76, '08/11/2020  11:30:03 PM', 'Missly Ann  Davalos', 'User has been Login', 'Cashier', 'D.Missly Ann'),
(77, '08/11/2020  11:30:12 PM', 'Missly Ann  Davalos', 'D.Missly AnnHas Logged-out', 'Cashier', 'D.Missly Ann'),
(78, '08/11/2020  11:30:20 PM', 'Elizabeth Tapic Sombilon', 'User has been Login', 'Enrollment Admin', 'S.Elizabeth'),
(79, '08/11/2020  11:30:27 PM', 'Elizabeth Tapic Sombilon', 'S.ElizabethHas Logged-out', 'Enrollment Admin', 'S.Elizabeth'),
(80, '08/11/2020  11:30:40 PM', 'Missly Ann  Davalos', 'User has been Login', 'Cashier', 'D.Missly Ann'),
(81, '08/11/2020  11:34:29 PM', 'Missly Ann  Davalos', 'D.Missly AnnHas Logged-out', 'Cashier', 'D.Missly Ann'),
(82, '08/11/2020  11:34:54 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(83, '08/11/2020  11:44:54 PM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(84, '08/11/2020  11:45:20 PM', 'Missly Ann  Davalos', 'User has been Login', 'Cashier', 'D.Missly Ann'),
(85, '08/11/2020  11:48:24 PM', 'Missly Ann  Davalos', 'D.Missly AnnHas Logged-out', 'Cashier', 'D.Missly Ann'),
(86, '08/11/2020  11:48:59 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(87, '08/11/2020  11:53:52 PM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(88, '08/11/2020  11:54:29 PM', 'Missly Ann  Davalos', 'User has been Login', 'Cashier', 'D.Missly Ann'),
(89, '08/11/2020  11:59:23 PM', 'Missly Ann  Davalos', 'D.Missly AnnHas Logged-out', 'Cashier', 'D.Missly Ann'),
(90, '08/12/2020  12:00:18 AM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(91, '08/12/2020  12:08:33 AM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(92, '08/12/2020  12:08:51 AM', 'Missly Ann  Davalos', 'User has been Login', 'Cashier', 'D.Missly Ann'),
(93, '08/12/2020  12:10:22 AM', 'Missly Ann  Davalos', 'D.Missly AnnHas Logged-out', 'Cashier', 'D.Missly Ann'),
(94, '08/12/2020  12:10:41 AM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(95, '08/12/2020  12:15:12 AM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(96, '08/12/2020  12:15:45 AM', 'Missly Ann  Davalos', 'User has been Login', 'Cashier', 'D.Missly Ann'),
(97, '08/12/2020  12:18:52 AM', 'Missly Ann  Davalos', 'D.Missly AnnHas Logged-out', 'Cashier', 'D.Missly Ann'),
(98, '08/12/2020  12:19:15 AM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(99, '08/12/2020  12:30:57 AM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(100, '08/12/2020  12:31:20 AM', 'Missly Ann  Davalos', 'User has been Login', 'Cashier', 'D.Missly Ann'),
(101, '08/12/2020  12:32:37 AM', 'Missly Ann  Davalos', 'D.Missly AnnHas Logged-out', 'Cashier', 'D.Missly Ann'),
(102, '08/12/2020  12:33:16 AM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(103, '08/12/2020  12:34:38 AM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(104, '08/12/2020  12:35:25 AM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(105, '08/12/2020  12:35:29 AM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(106, '08/12/2020  12:44:17 AM', 'Elizabeth Tapic Sombilon', 'User has been Login', 'Enrollment Admin', 'S.Elizabeth'),
(107, '08/12/2020  12:45:12 AM', 'Elizabeth Tapic Sombilon', 'S.ElizabethHas Logged-out', 'Enrollment Admin', 'S.Elizabeth'),
(108, '08/12/2020  12:45:38 AM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(109, '08/12/2020  12:52:34 AM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(110, '08/12/2020  12:53:51 AM', 'Missly Ann  Davalos', 'User has been Login', 'Cashier', 'D.Missly Ann'),
(111, '08/12/2020  12:55:50 AM', 'Missly Ann  Davalos', 'D.Missly AnnHas Logged-out', 'Cashier', 'D.Missly Ann'),
(112, '08/12/2020  12:56:36 AM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(113, '08/12/2020  01:06:18 AM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(114, '08/12/2020  01:06:40 AM', 'Missly Ann  Davalos', 'User has been Login', 'Cashier', 'D.Missly Ann'),
(115, '08/12/2020  01:07:18 AM', 'Missly Ann  Davalos', 'D.Missly AnnHas Logged-out', 'Cashier', 'D.Missly Ann'),
(116, '08/12/2020  01:08:07 AM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(117, '08/12/2020  08:55:22 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(118, '08/12/2020  08:55:52 PM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(119, '08/12/2020  08:56:05 PM', 'Missly Ann  Davalos', 'User has been Login', 'Cashier', 'D.Missly Ann'),
(120, '08/12/2020  08:59:02 PM', 'Missly Ann  Davalos', 'D.Missly AnnHas Logged-out', 'Cashier', 'D.Missly Ann'),
(121, '08/12/2020  08:59:29 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(122, '08/12/2020  09:20:33 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(123, '08/12/2020  09:35:31 PM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(124, '08/12/2020  09:35:46 PM', 'Missly Ann  Davalos', 'User has been Login', 'Cashier', 'D.Missly Ann'),
(125, '08/12/2020  09:37:30 PM', 'Missly Ann  Davalos', 'D.Missly AnnHas Logged-out', 'Cashier', 'D.Missly Ann'),
(126, '08/12/2020  09:38:27 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(127, '08/12/2020  09:38:49 PM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(128, '08/12/2020  09:46:44 PM', 'Elizabeth Tapic Sombilon', 'User has been Login', 'Enrollment Admin', 'S.Elizabeth'),
(129, '08/12/2020  09:48:30 PM', 'Elizabeth Tapic Sombilon', 'S.ElizabethHas Logged-out', 'Enrollment Admin', 'S.Elizabeth'),
(130, '08/12/2020  09:48:47 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'B.Khristine Joy'),
(131, '08/12/2020  10:00:59 PM', 'Khristine Guinto Badiana', 'B.Khristine JoyHas Logged-out', 'System Admin', 'B.Khristine Joy'),
(132, '08/12/2020  10:01:55 PM', 'Daniel  Doronilla', 'User has been Login', 'Teacher', 'D.Daniel'),
(133, '08/12/2020  10:22:02 PM', 'Daniel  Doronilla', 'D.DanielHas Logged-out', 'Teacher', 'D.Daniel'),
(134, '08/12/2020  10:22:19 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'B.Khristine Joy'),
(135, '08/12/2020  10:22:54 PM', 'Khristine Guinto Badiana', 'B.Khristine JoyHas Logged-out', 'System Admin', 'B.Khristine Joy'),
(136, '08/12/2020  10:23:44 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(137, '08/12/2020  10:23:49 PM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(138, '08/12/2020  10:24:03 PM', 'Elizabeth Tapic Sombilon', 'User has been Login', 'Enrollment Admin', 'S.Elizabeth'),
(139, '08/12/2020  10:24:26 PM', 'Elizabeth Tapic Sombilon', 'S.ElizabethHas Logged-out', 'Enrollment Admin', 'S.Elizabeth'),
(140, '08/12/2020  10:24:39 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(141, '08/12/2020  10:29:04 PM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(142, '08/12/2020  10:29:24 PM', 'Missly Ann  Davalos', 'User has been Login', 'Cashier', 'D.Missly Ann'),
(143, '08/12/2020  10:31:50 PM', 'Missly Ann  Davalos', 'D.Missly AnnHas Logged-out', 'Cashier', 'D.Missly Ann'),
(144, '08/12/2020  10:32:13 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'B.Khristine Joy'),
(145, '08/12/2020  10:32:31 PM', 'Khristine Guinto Badiana', 'B.Khristine JoyHas Logged-out', 'System Admin', 'B.Khristine Joy'),
(146, '08/12/2020  10:32:54 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(147, '08/12/2020  10:32:57 PM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(148, '08/12/2020  10:33:27 PM', 'Elizabeth Tapic Sombilon', 'User has been Login', 'Enrollment Admin', 'S.Elizabeth'),
(149, '08/12/2020  10:33:44 PM', 'Elizabeth Tapic Sombilon', 'S.ElizabethHas Logged-out', 'Enrollment Admin', 'S.Elizabeth'),
(150, '08/12/2020  10:33:52 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(151, '08/12/2020  10:45:20 PM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(152, '08/12/2020  10:46:12 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'B.Khristine Joy'),
(153, '08/12/2020  10:46:34 PM', 'Khristine Guinto Badiana', 'B.Khristine JoyHas Logged-out', 'System Admin', 'B.Khristine Joy'),
(154, '08/12/2020  10:47:15 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(155, '08/12/2020  10:58:53 PM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(156, '08/12/2020  10:59:17 PM', 'Missly Ann  Davalos', 'User has been Login', 'Cashier', 'D.Missly Ann'),
(157, '08/12/2020  11:03:17 PM', 'Missly Ann  Davalos', 'D.Missly AnnHas Logged-out', 'Cashier', 'D.Missly Ann'),
(158, '08/12/2020  11:03:39 PM', 'Jacob C Alapapara', 'User has been Login', 'Teacher', 'A.Jacob'),
(159, '08/12/2020  11:17:16 PM', 'Jacob C Alapapara', 'A.JacobHas Logged-out', 'Teacher', 'A.Jacob'),
(160, '08/12/2020  11:17:40 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'B.Khristine Joy'),
(161, '08/12/2020  11:17:54 PM', 'Khristine Guinto Badiana', 'B.Khristine JoyHas Logged-out', 'System Admin', 'B.Khristine Joy'),
(162, '08/12/2020  11:18:04 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(163, '08/12/2020  11:25:09 PM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(164, '08/13/2020  09:01:46 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(165, '08/13/2020  09:02:40 PM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(166, '08/13/2020  09:02:55 PM', 'Missly Ann  Davalos', 'User has been Login', 'Cashier', 'D.Missly Ann'),
(167, '08/13/2020  09:10:22 PM', 'Missly Ann  Davalos', 'D.Missly AnnHas Logged-out', 'Cashier', 'D.Missly Ann'),
(168, '08/13/2020  09:10:33 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(169, '08/13/2020  09:10:48 PM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(170, '08/13/2020  09:11:07 PM', 'Missly Ann  Davalos', 'User has been Login', 'Cashier', 'D.Missly Ann'),
(171, '08/13/2020  09:11:52 PM', 'Missly Ann  Davalos', 'D.Missly AnnHas Logged-out', 'Cashier', 'D.Missly Ann'),
(172, '08/13/2020  09:12:03 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'B.Khristine Joy'),
(173, '08/13/2020  09:12:16 PM', 'Khristine Guinto Badiana', 'B.Khristine JoyHas Logged-out', 'System Admin', 'B.Khristine Joy'),
(174, '08/13/2020  09:12:25 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(175, '08/13/2020  09:18:07 PM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(176, '08/13/2020  09:18:21 PM', 'Jelleen  Isidro', 'User has been Login', 'Teacher', 'I.Jelleen'),
(177, '08/13/2020  09:21:52 PM', 'Jelleen  Isidro', 'I.JelleenHas Logged-out', 'Teacher', 'I.Jelleen'),
(178, '08/13/2020  09:22:16 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'B.Khristine Joy'),
(179, '08/13/2020  09:22:30 PM', 'Khristine Guinto Badiana', 'B.Khristine JoyHas Logged-out', 'System Admin', 'B.Khristine Joy'),
(180, '08/13/2020  09:22:43 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(181, '08/13/2020  09:23:42 PM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(182, '08/13/2020  09:24:16 PM', 'Elizabeth Tapic Sombilon', 'User has been Login', 'Enrollment Admin', 'S.Elizabeth'),
(183, '08/13/2020  09:24:48 PM', 'Elizabeth Tapic Sombilon', 'S.ElizabethHas Logged-out', 'Enrollment Admin', 'S.Elizabeth'),
(184, '08/13/2020  09:30:42 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(185, '08/13/2020  09:33:36 PM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(186, '08/13/2020  09:33:47 PM', 'Missly Ann  Davalos', 'User has been Login', 'Cashier', 'D.Missly Ann'),
(187, '08/13/2020  09:37:50 PM', 'Missly Ann  Davalos', 'D.Missly AnnHas Logged-out', 'Cashier', 'D.Missly Ann'),
(188, '08/21/2020  01:52:03 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(189, '08/21/2020  01:52:37 PM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(190, '08/21/2020  01:53:21 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'B.Khristine Joy'),
(191, '08/21/2020  01:53:46 PM', 'Khristine Guinto Badiana', 'B.Khristine JoyHas Logged-out', 'System Admin', 'B.Khristine Joy'),
(192, '08/21/2020  01:54:09 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(193, '08/21/2020  02:00:25 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'B.Khristine Joy'),
(194, '08/21/2020  02:02:25 PM', 'Khristine Guinto Badiana', 'B.Khristine JoyHas Logged-out', 'System Admin', 'B.Khristine Joy'),
(195, '08/21/2020  02:03:40 PM', 'Elizabeth Tapic Sombilon', 'User has been Login', 'Enrollment Admin', 'S.Elizabeth'),
(196, '08/21/2020  02:03:49 PM', 'Elizabeth Tapic Sombilon', 'S.ElizabethHas Logged-out', 'Enrollment Admin', 'S.Elizabeth'),
(197, '08/21/2020  02:04:11 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(198, '08/21/2020  02:04:30 PM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(199, '08/21/2020  02:21:18 PM', 'Missly Ann  Davalos', 'User has been Login', 'Cashier', 'D.Missly Ann'),
(200, '08/21/2020  02:26:55 PM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(201, '08/21/2020  02:29:54 PM', 'Missly Ann  Davalos', 'D.Missly AnnHas Logged-out', 'Cashier', 'D.Missly Ann'),
(202, '08/21/2020  02:31:53 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(203, '08/21/2020  02:31:58 PM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(204, '08/21/2020  02:33:00 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(205, '08/21/2020  02:35:35 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'B.Khristine Joy'),
(206, '08/21/2020  03:09:35 PM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(207, '08/21/2020  03:09:51 PM', 'Missly Ann  Davalos', 'User has been Login', 'Cashier', 'D.Missly Ann'),
(208, '08/21/2020  03:12:12 PM', 'Khristine Guinto Badiana', 'B.Khristine JoyHas Logged-out', 'System Admin', 'B.Khristine Joy'),
(209, '08/21/2020  03:12:47 PM', 'Daniel  Doronilla', 'User has been Login', 'Teacher', 'D.Daniel'),
(210, '08/21/2020  03:13:44 PM', 'Missly Ann  Davalos', 'D.Missly AnnHas Logged-out', 'Cashier', 'D.Missly Ann'),
(211, '08/21/2020  03:14:13 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(212, '08/21/2020  03:15:55 PM', 'Daniel  Doronilla', 'D.DanielHas Logged-out', 'Teacher', 'D.Daniel'),
(213, '08/21/2020  03:16:26 PM', 'Brylle H Poblete', 'User has been Login', 'Teacher', 'P.Brylle'),
(214, '08/21/2020  03:14:53 PM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(215, '08/21/2020  03:15:26 PM', 'Missly Ann  Davalos', 'User has been Login', 'Cashier', 'D.Missly Ann'),
(216, '08/21/2020  03:16:10 PM', 'Missly Ann  Davalos', 'D.Missly AnnHas Logged-out', 'Cashier', 'D.Missly Ann'),
(217, '08/21/2020  03:16:29 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(218, '08/21/2020  03:18:12 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(219, '08/21/2020  03:19:03 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(220, '08/21/2020  03:20:47 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(221, '08/21/2020  03:22:06 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(222, '08/21/2020  03:24:43 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(223, '08/21/2020  03:26:06 PM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(224, '08/21/2020  03:26:23 PM', 'Missly Ann  Davalos', 'User has been Login', 'Cashier', 'D.Missly Ann'),
(225, '08/21/2020  03:26:33 PM', 'Missly Ann  Davalos', 'D.Missly AnnHas Logged-out', 'Cashier', 'D.Missly Ann'),
(226, '08/21/2020  03:26:45 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(227, '08/21/2020  03:32:37 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'B.Khristine Joy'),
(228, '08/21/2020  03:32:57 PM', 'Khristine Guinto Badiana', 'B.Khristine JoyHas Logged-out', 'System Admin', 'B.Khristine Joy'),
(229, '08/21/2020  03:33:08 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(230, '08/21/2020  03:36:09 PM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(231, '08/21/2020  03:36:37 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'B.Khristine Joy'),
(232, '08/21/2020  03:37:06 PM', 'Khristine Guinto Badiana', 'B.Khristine JoyHas Logged-out', 'System Admin', 'B.Khristine Joy'),
(233, '08/21/2020  03:37:51 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(234, '08/21/2020  03:40:32 PM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(235, '08/28/2020  02:25:41 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'B.Khristine Joy'),
(236, '08/28/2020  02:25:53 PM', 'Khristine Guinto Badiana', 'B.Khristine JoyHas Logged-out', 'System Admin', 'B.Khristine Joy'),
(237, '08/28/2020  02:26:07 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(238, '08/28/2020  02:31:05 PM', 'Missly Ann  Davalos', 'User has been Login', 'Cashier', 'D.Missly Ann'),
(239, '08/28/2020  02:35:15 PM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(240, '08/28/2020  02:39:23 PM', 'Missly Ann  Davalos', 'D.Missly AnnHas Logged-out', 'Cashier', 'D.Missly Ann'),
(241, '08/28/2020  02:39:56 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(242, '08/28/2020  02:43:07 PM', 'Paula  Uy', 'User has been Login', 'Teacher', 'U.Paula'),
(243, '08/28/2020  02:50:38 PM', 'Paula  Uy', 'U.PaulaHas Logged-out', 'Teacher', 'U.Paula'),
(244, '08/28/2020  02:52:06 PM', 'Edman G Pebenito', 'User has been Login', 'Teacher', 'P.Edman'),
(245, '08/28/2020  02:53:24 PM', 'Edman G Pebenito', 'P.EdmanHas Logged-out', 'Teacher', 'P.Edman'),
(246, '08/28/2020  02:54:29 PM', 'Jexter  Suba', 'User has been Login', 'Teacher', 'S.Jexter'),
(247, '08/28/2020  02:56:08 PM', 'Jexter  Suba', 'User has been Login', 'Teacher', 'S.Jexter'),
(248, '08/28/2020  02:57:33 PM', 'Jexter  Suba', 'S.JexterHas Logged-out', 'Teacher', 'S.Jexter'),
(249, '08/28/2020  02:58:08 PM', 'Randolf H Mangubat', 'User has been Login', 'Teacher', 'M.Randolf'),
(250, '08/28/2020  02:58:20 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(251, '08/28/2020  03:01:05 PM', 'Randolf H Mangubat', 'M.RandolfHas Logged-out', 'Teacher', 'M.Randolf'),
(252, '08/28/2020  03:01:59 PM', 'Asher G Giron', 'User has been Login', 'Teacher', 'G.Asher'),
(253, '08/28/2020  03:03:41 PM', 'Asher G Giron', 'G.AsherHas Logged-out', 'Teacher', 'G.Asher'),
(254, '08/28/2020  03:04:06 PM', 'Mae  Gallardo', 'User has been Login', 'Teacher', 'G.Mae'),
(255, '08/28/2020  03:05:34 PM', 'Mae  Gallardo', 'G.MaeHas Logged-out', 'Teacher', 'G.Mae'),
(256, '08/28/2020  03:06:50 PM', 'Evan Richert  Tan', 'User has been Login', 'Teacher', 'T.Evan Richert'),
(257, '08/28/2020  03:08:21 PM', 'Evan Richert  Tan', 'T.Evan RichertHas Logged-out', 'Teacher', 'T.Evan Richert'),
(258, '08/28/2020  03:10:12 PM', 'Carl Cruz Dela Cruz', 'User has been Login', 'Teacher', 'D.Carl'),
(259, '08/28/2020  03:11:33 PM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(260, '08/28/2020  03:11:50 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'B.Khristine Joy'),
(261, '08/28/2020  03:11:52 PM', 'Carl Cruz Dela Cruz', 'D.CarlHas Logged-out', 'Teacher', 'D.Carl'),
(262, '08/28/2020  03:12:00 PM', 'Khristine Guinto Badiana', 'B.Khristine JoyHas Logged-out', 'System Admin', 'B.Khristine Joy'),
(263, '08/28/2020  03:15:57 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(264, '08/28/2020  03:17:10 PM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(265, '08/28/2020  03:17:50 PM', 'Missly Ann  Davalos', 'User has been Login', 'Cashier', 'D.Missly Ann'),
(266, '08/28/2020  03:18:24 PM', 'Missly Ann  Davalos', 'D.Missly AnnHas Logged-out', 'Cashier', 'D.Missly Ann'),
(267, '08/28/2020  03:18:38 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'B.Khristine Joy'),
(268, '08/28/2020  03:19:11 PM', 'Paula  Uy', 'User has been Login', 'Teacher', 'U.Paula'),
(269, '08/28/2020  03:20:53 PM', 'Paula  Uy', 'U.PaulaHas Logged-out', 'Teacher', 'U.Paula'),
(270, '08/28/2020  03:21:06 PM', 'Edman G Pebenito', 'User has been Login', 'Teacher', 'P.Edman'),
(271, '08/28/2020  03:21:47 PM', 'Edman G Pebenito', 'P.EdmanHas Logged-out', 'Teacher', 'P.Edman'),
(272, '08/28/2020  03:22:01 PM', 'Randolf H Mangubat', 'User has been Login', 'Teacher', 'M.Randolf'),
(273, '08/28/2020  03:22:34 PM', 'Randolf H Mangubat', 'M.RandolfHas Logged-out', 'Teacher', 'M.Randolf'),
(274, '08/28/2020  03:22:52 PM', 'Khristine Guinto Badiana', 'B.Khristine JoyHas Logged-out', 'System Admin', 'B.Khristine Joy'),
(275, '08/28/2020  03:23:08 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(276, '08/28/2020  03:26:40 PM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(277, '08/28/2020  03:27:25 PM', 'Missly Ann  Davalos', 'User has been Login', 'Cashier', 'D.Missly Ann'),
(278, '08/28/2020  03:35:19 PM', 'Missly Ann  Davalos', 'D.Missly AnnHas Logged-out', 'Cashier', 'D.Missly Ann'),
(279, '08/28/2020  03:35:44 PM', 'Khristine Guinto Badiana', 'User has been Login', 'System Admin', 'B.Khristine Joy'),
(280, '08/28/2020  03:36:09 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(281, '08/28/2020  03:37:13 PM', 'Khristine Guinto Badiana', 'B.Khristine JoyHas Logged-out', 'System Admin', 'B.Khristine Joy'),
(282, '08/28/2020  03:37:12 PM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(283, '08/28/2020  03:38:28 PM', 'Marisol Asis Jadlocon', 'User has been Login', 'Registrar', 'J.Marisol'),
(284, '08/28/2020  03:41:53 PM', 'Marisol Asis Jadlocon', 'J.MarisolHas Logged-out', 'Registrar', 'J.Marisol'),
(285, '08/28/2020  03:42:30 PM', 'Paula  Uy', 'User has been Login', 'Teacher', 'U.Paula'),
(286, '08/28/2020  03:44:53 PM', 'Paula  Uy', 'User has been Login', 'Teacher', 'U.Paula'),
(287, '08/28/2020  03:46:16 PM', 'Paula  Uy', 'User has been Login', 'Teacher', 'U.Paula');

-- --------------------------------------------------------

--
-- Table structure for table `classroom`
--

CREATE TABLE `classroom` (
  `classroom_id` int(11) NOT NULL,
  `classroom_type` int(11) NOT NULL,
  `classroom_no` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `classroom`
--

INSERT INTO `classroom` (`classroom_id`, `classroom_type`, `classroom_no`) VALUES
(1, 3, 1),
(2, 3, 2),
(3, 3, 3),
(4, 3, 4),
(5, 3, 5),
(6, 3, 6),
(7, 3, 7),
(8, 3, 8),
(9, 3, 9),
(10, 3, 10),
(11, 3, 11),
(12, 3, 12),
(13, 3, 13),
(14, 3, 14),
(15, 3, 15),
(16, 3, 16),
(17, 3, 17),
(18, 3, 18),
(19, 3, 19),
(20, 3, 20),
(21, 3, 21),
(22, 3, 22),
(23, 3, 23),
(24, 3, 24),
(25, 3, 25);

-- --------------------------------------------------------

--
-- Table structure for table `classroom_type`
--

CREATE TABLE `classroom_type` (
  `classroom_type_id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `classroom_type`
--

INSERT INTO `classroom_type` (`classroom_type_id`, `name`) VALUES
(1, 'Science Laboratory'),
(2, 'Computer Laboratory'),
(3, 'Room');

-- --------------------------------------------------------

--
-- Table structure for table `enrollment_schedule`
--

CREATE TABLE `enrollment_schedule` (
  `enrollment_sched_id` int(11) NOT NULL,
  `start_date` text NOT NULL,
  `end_date` text NOT NULL,
  `is_open` int(11) NOT NULL,
  `SY_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `enrollment_schedule`
--

INSERT INTO `enrollment_schedule` (`enrollment_sched_id`, `start_date`, `end_date`, `is_open`, `SY_id`) VALUES
(1, '10/08/2020', '15/08/2020', 1, 1),
(2, '12/08/2020', '16/08/2020', 1, 9),
(3, '12/08/2020', '16/08/2020', 1, 8);

-- --------------------------------------------------------

--
-- Table structure for table `grade_level`
--

CREATE TABLE `grade_level` (
  `gradelvl_id` int(11) NOT NULL,
  `grade_type` text NOT NULL,
  `grade_level` text NOT NULL,
  `SY_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `misc_fee`
--

CREATE TABLE `misc_fee` (
  `miscfee_id` int(11) NOT NULL,
  `details` text NOT NULL,
  `price` int(11) NOT NULL,
  `grade_level` text NOT NULL,
  `SY_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `misc_fee`
--

INSERT INTO `misc_fee` (`miscfee_id`, `details`, `price`, `grade_level`, `SY_ID`) VALUES
(35, 'Medical', 200, 'Nursery', 1),
(36, 'Insurance', 100, 'Nursery', 1),
(37, 'Dental', 200, 'Nursery', 1),
(38, 'Scouting', 200, 'Nursery', 1),
(40, 'Instructional and Test Material', 400, 'Nursery', 1),
(41, 'Library', 200, 'Nursery', 1),
(42, 'Guidance', 500, 'Nursery', 1),
(43, 'Development Fee', 600, 'Nursery', 1),
(44, 'ID', 250, 'Nursery', 1),
(45, 'Audio Visual', 300, 'Nursery', 1),
(46, 'Aircon', 700, 'Nursery', 1),
(47, 'Computer', 500, 'Nursery', 1),
(48, 'Medical', 200, 'Junior Kinder', 1),
(49, 'Insurance', 100, 'Junior Kinder', 1),
(50, 'Dental', 200, 'Junior Kinder', 1),
(51, 'Scouting', 200, 'Junior Kinder', 1),
(52, 'Instructional and Test Material', 400, 'Junior Kinder', 1),
(53, 'Library', 200, 'Junior Kinder', 1),
(54, 'Guidance', 500, 'Junior Kinder', 1),
(55, 'Development Fee', 600, 'Junior Kinder', 1),
(56, 'ID', 250, 'Junior Kinder', 1),
(57, 'Audio Visual', 300, 'Junior Kinder', 1),
(58, 'Aircon', 700, 'Junior Kinder', 1),
(59, 'Computer', 500, 'Junior Kinder', 1),
(60, 'Medical', 200, 'Senior Kinder', 1),
(61, 'Insurance', 100, 'Senior Kinder', 1),
(62, 'Dental', 200, 'Senior Kinder', 1),
(63, 'Scouting', 200, 'Senior Kinder', 1),
(64, 'Instuctional and Test Material', 400, 'Senior Kinder', 1),
(65, 'Library', 200, 'Senior Kinder', 1),
(66, 'Guidance', 500, 'Senior Kinder', 1),
(67, 'Development Fee', 600, 'Senior Kinder', 1),
(68, 'ID', 250, 'Senior Kinder', 1),
(69, 'Audio Visual', 300, 'Senior Kinder', 1),
(70, 'Aircon', 700, 'Senior Kinder', 1),
(71, 'Computer', 500, 'Senior Kinder', 1),
(72, 'Medical', 200, 'Grade 1', 1),
(73, 'Insurance', 100, 'Grade 1', 1),
(74, 'Dental', 200, 'Grade 1', 1),
(75, 'Scouting', 200, 'Grade 1', 1),
(76, 'Insructional and Test Material', 400, 'Grade 1', 1),
(77, 'Library', 200, 'Grade 1', 1),
(78, 'Guidance', 500, 'Grade 1', 1),
(79, 'Development Fee', 600, 'Grade 1', 1),
(80, 'ID', 250, 'Grade 1', 1),
(81, 'Audio Visual', 300, 'Grade 1', 1),
(82, 'Aircon', 700, 'Grade 1', 1),
(83, 'Computer', 500, 'Grade 1', 1),
(85, 'Medical', 200, 'Grade 2', 1),
(86, 'Insurance', 100, 'Grade 2', 1),
(87, 'Dental', 200, 'Grade 2', 1),
(88, 'Scouting', 200, 'Grade 2', 1),
(89, 'International and Test Material', 400, 'Grade 2', 1),
(90, 'Library', 200, 'Grade 2', 1),
(91, 'Guidance', 500, 'Grade 2', 1),
(92, 'Development Fee', 600, 'Grade 2', 1),
(93, 'ID', 250, 'Grade 2', 1),
(94, 'Audio Visual', 300, 'Grade 2', 1),
(95, 'Aircon', 700, 'Grade 2', 1),
(96, 'Computer', 500, 'Grade 2', 1),
(97, 'Medical', 200, 'Grade 3', 1),
(98, 'Insurance', 100, 'Grade 3', 1),
(99, 'Dental', 200, 'Grade 3', 1),
(100, 'Scouting', 200, 'Grade 3', 1),
(101, 'Instructional and Test Material', 400, 'Grade 3', 1),
(102, 'Library', 200, 'Grade 3', 1),
(103, 'Guidance', 500, 'Grade 3', 1),
(104, 'Development Fee', 600, 'Grade 3', 1),
(105, 'ID', 250, 'Grade 3', 1),
(106, 'Audio Visual', 300, 'Grade 3', 1),
(107, 'Aircon', 700, 'Grade 3', 1),
(108, 'Computer', 500, 'Grade 3', 1),
(109, 'Medical', 200, 'Grade 4', 1),
(110, 'Insurance', 100, 'Grade 4', 1),
(111, 'Dental', 200, 'Grade 4', 1),
(112, 'Scouting', 200, 'Grade 4', 1),
(113, 'Instructional and Test Material', 400, 'Grade 4', 1),
(114, 'Library', 200, 'Grade 4', 1),
(115, 'Guidance', 500, 'Grade 4', 1),
(116, 'Development Fee', 600, 'Grade 4', 1),
(117, 'ID', 250, 'Grade 4', 1),
(118, 'Audio Visual', 300, 'Grade 4', 1),
(119, 'Aircon', 700, 'Grade 4', 1),
(120, 'Computer', 500, 'Grade 4', 1),
(121, 'Medical', 200, 'Grade 5', 1),
(122, 'Insurance', 100, 'Grade 5', 1),
(123, 'Dental', 200, 'Grade 5', 1),
(124, 'Scouting', 200, 'Grade 5', 1),
(125, 'Instructional and Test Material', 400, 'Grade 5', 1),
(126, 'Library', 200, 'Grade 5', 1),
(127, 'Guidance', 500, 'Grade 5', 1),
(128, 'Development Fee', 600, 'Grade 5', 1),
(129, 'ID', 250, 'Grade 5', 1),
(130, 'Audio Visual', 300, 'Grade 5', 1),
(131, 'Aircon', 700, 'Grade 5', 1),
(132, 'Computer', 500, 'Grade 5', 1),
(133, 'Medical', 200, 'Grade 6', 1),
(134, 'Insurance', 100, 'Grade 6', 1),
(135, 'Dental', 200, 'Grade 6', 1),
(136, 'Scouting', 200, 'Grade 6', 1),
(137, 'Instructional and Test Material', 400, 'Grade 6', 1),
(138, 'Library', 200, 'Grade 6', 1),
(139, 'Guidance', 500, 'Grade 6', 1),
(140, 'Development Fee', 600, 'Grade 6', 1),
(141, 'ID', 250, 'Grade 6', 1),
(142, 'Audio Visual', 300, 'Grade 6', 1),
(143, 'Aircon', 700, 'Grade 6', 1),
(144, 'Computer', 500, 'Grade 6', 1),
(145, 'Medical', 200, 'Grade 7', 1),
(146, 'Insurance', 100, 'Grade 7', 1),
(147, 'Dental', 200, 'Grade 7', 1),
(148, 'Scouting', 200, 'Grade 7', 1),
(149, 'Instructional and Test Material', 400, 'Grade 7', 1),
(150, 'Library', 200, 'Grade 7', 1),
(151, 'Guidance', 500, 'Grade 7', 1),
(152, 'Development Fee', 600, 'Grade 7', 1),
(153, 'ID', 250, 'Grade 7', 1),
(154, 'Audio Visual', 300, 'Grade 7', 1),
(155, 'Computer', 500, 'Grade 7', 1),
(156, 'Medical', 200, 'Grade 8', 1),
(157, 'Insurance', 100, 'Grade 8', 1),
(158, 'Dental', 200, 'Grade 8', 1),
(159, 'Scouting', 200, 'Grade 8', 1),
(160, 'Instructional and test Material', 400, 'Grade 8', 1),
(161, 'Library', 200, 'Grade 8', 1),
(162, 'Guidance', 500, 'Grade 8', 1),
(163, 'Development Fee', 600, 'Grade 8', 1),
(164, 'ID', 250, 'Grade 8', 1),
(165, 'Audio Visual', 300, 'Grade 8', 1),
(166, 'Aircon', 700, 'Grade 8', 1),
(167, 'Computer', 500, 'Grade 8', 1),
(168, 'Medical', 200, 'Grade 9', 1),
(169, 'Insurance', 100, 'Grade 9', 1),
(170, 'Dental', 200, 'Grade 9', 1),
(171, 'Scouting', 200, 'Grade 9', 1),
(172, 'Instructional and test Material', 400, 'Grade 9', 1),
(173, 'Library', 200, 'Grade 9', 1),
(174, 'Guidance', 500, 'Grade 9', 1),
(175, 'Development Fee', 600, 'Grade 9', 1),
(176, 'ID', 250, 'Grade 9', 1),
(177, 'Audio Visual', 300, 'Grade 9', 1),
(178, 'Aircon', 700, 'Grade 9', 1),
(179, 'Computer', 500, 'Grade 9', 1),
(180, 'Medical', 200, 'Grade 10', 1),
(181, 'Insurance', 100, 'Grade 10', 1),
(182, 'Dental', 200, 'Grade 10', 1),
(183, 'Scouting', 200, 'Grade 10', 1),
(184, 'Instructional and Test Material', 400, 'Grade 10', 1),
(185, 'Library', 200, 'Grade 10', 1),
(186, 'Guidance', 500, 'Grade 10', 1),
(187, 'Development Fee', 600, 'Grade 10', 1),
(188, 'ID', 250, 'Grade 10', 1),
(189, 'Audio Visual', 300, 'Grade 10', 1),
(190, 'Aircon', 700, 'Grade 10', 1),
(191, 'Computer', 500, 'Grade 10', 1),
(192, 'Medical', 200, 'Nursery', 9),
(193, 'Insurance', 100, 'Nursery', 9),
(194, 'Dental', 200, 'Nursery', 9),
(195, 'Scouting', 200, 'Nursery', 9),
(196, 'Instructional and Test Material', 400, 'Nursery', 9),
(197, 'Library', 200, 'Nursery', 9),
(198, 'Guidance', 500, 'Nursery', 9),
(199, 'Development Fee', 600, 'Nursery', 9),
(200, 'ID', 250, 'Nursery', 9),
(201, 'Audio Visual', 300, 'Nursery', 9),
(202, 'Aircon', 700, 'Nursery', 9),
(203, 'Computer', 500, 'Nursery', 9),
(204, 'Medical', 200, 'Junior Kinder', 9),
(205, 'Insurance', 100, 'Junior Kinder', 9),
(206, 'Dental', 200, 'Junior Kinder', 9),
(207, 'Scouting', 200, 'Junior Kinder', 9),
(208, 'Instructional and Test Material', 400, 'Junior Kinder', 9),
(209, 'Library', 200, 'Junior Kinder', 9),
(210, 'Guidance', 500, 'Junior Kinder', 9),
(211, 'Development Fee', 600, 'Junior Kinder', 9),
(212, 'ID', 250, 'Junior Kinder', 9),
(213, 'Audio Visual', 300, 'Junior Kinder', 9),
(214, 'Aircon', 700, 'Junior Kinder', 9),
(215, 'Computer', 500, 'Junior Kinder', 9),
(216, 'Medical', 200, 'Senior Kinder', 9),
(217, 'Insurance', 100, 'Senior Kinder', 9),
(218, 'Dental', 200, 'Senior Kinder', 9),
(219, 'Scouting', 200, 'Senior Kinder', 9),
(220, 'Instructional and Test Material', 400, 'Senior Kinder', 9),
(221, 'Library', 200, 'Senior Kinder', 9),
(222, 'Guidance', 500, 'Senior Kinder', 9),
(223, 'Development Fee', 600, 'Senior Kinder', 9),
(224, 'ID', 250, 'Senior Kinder', 9),
(225, 'Audio Visual', 300, 'Senior Kinder', 9),
(226, 'Aircon', 700, 'Senior Kinder', 9),
(227, 'Computer', 500, 'Senior Kinder', 9),
(228, 'Medical', 200, 'Grade 1', 9),
(229, 'Insurance', 100, 'Grade 1', 9),
(230, 'Dental', 200, 'Grade 1', 9),
(231, 'Scouting', 200, 'Grade 1', 9),
(232, 'Instructional and Test Material', 400, 'Grade 1', 9),
(233, 'Library', 200, 'Grade 1', 9),
(234, 'Guidance', 500, 'Grade 1', 9),
(235, 'Development Fee', 600, 'Grade 1', 9),
(236, 'Audio Visual', 300, 'Grade 1', 9),
(237, 'Aircon', 700, 'Grade 1', 9),
(238, 'Computer', 500, 'Grade 1', 9),
(239, 'Medical', 200, 'Grade 2', 9),
(240, 'Insurance', 100, 'Grade 2', 9),
(241, 'Dental', 200, 'Grade 2', 9),
(242, 'Scouting', 200, 'Grade 2', 9),
(243, 'Instructional and Test Material', 400, 'Grade 2', 9),
(244, 'Library', 200, 'Grade 2', 9),
(245, 'Guidance', 500, 'Grade 2', 9),
(246, 'Development Fee', 600, 'Grade 2', 9),
(247, 'ID', 250, 'Grade 2', 9),
(248, 'Audio Visual', 300, 'Grade 2', 9),
(249, 'Aircon', 700, 'Grade 2', 9),
(250, 'Computer', 500, 'Grade 2', 9),
(251, 'Medical', 200, 'Grade 3', 9),
(252, 'Insurance', 100, 'Grade 3', 9),
(253, 'Dental', 200, 'Grade 3', 9),
(254, 'Scouting', 200, 'Grade 3', 9),
(255, 'Instructional and Test Material', 400, 'Grade 3', 9),
(256, 'Library', 200, 'Grade 3', 9),
(257, 'Guidance', 500, 'Grade 3', 9),
(258, 'Development Fee', 600, 'Grade 3', 9),
(259, 'ID', 250, 'Grade 3', 9),
(260, 'Audio Visual', 300, 'Grade 3', 9),
(261, 'Aircon', 700, 'Grade 3', 9),
(262, 'Computer', 500, 'Grade 3', 9),
(264, 'Medical', 200, 'Grade 4', 9),
(265, 'Insurance', 100, 'Grade 4', 9),
(266, 'Dental', 200, 'Grade 4', 9),
(267, 'Scouting', 200, 'Grade 4', 9),
(268, 'Instructional and Test Material', 400, 'Grade 4', 9),
(269, 'Library', 200, 'Grade 4', 9),
(270, 'Guidance', 500, 'Grade 4', 9),
(271, 'Development Fee', 600, 'Grade 4', 9),
(272, 'ID', 250, 'Grade 4', 9),
(273, 'Audio Visual', 300, 'Grade 4', 9),
(274, 'Aircon', 700, 'Grade 4', 9),
(275, 'Computer', 500, 'Grade 4', 9),
(276, 'Medical', 200, 'Grade 5', 9),
(277, 'Insurance', 100, 'Grade 5', 9),
(278, 'Dental', 200, 'Grade 5', 9),
(279, 'Scouting', 200, 'Grade 5', 9),
(280, 'Instructional and Test Material', 400, 'Grade 5', 9),
(281, 'Library', 200, 'Grade 5', 9),
(282, 'Guidance', 500, 'Grade 5', 9),
(283, 'Development Fee', 600, 'Grade 5', 9),
(284, 'ID', 250, 'Grade 5', 9),
(285, 'Audio Visual', 300, 'Grade 5', 9),
(286, 'Aircon', 700, 'Grade 5', 9),
(287, 'Computer', 500, 'Grade 5', 9),
(288, 'Medical', 200, 'Grade 6', 9),
(289, 'Insurance', 100, 'Grade 6', 9),
(290, 'Dental', 200, 'Grade 6', 9),
(291, 'Dental', 200, 'Grade 6', 9),
(292, 'Instructional and Test Material', 400, 'Grade 6', 9),
(293, 'Library', 200, 'Grade 6', 9),
(294, 'Guidance', 500, 'Grade 6', 9),
(295, 'Development Fee', 600, 'Grade 6', 9),
(296, 'ID', 250, 'Grade 6', 9),
(297, 'Audio Visual', 300, 'Grade 6', 9),
(298, 'Aircon', 700, 'Grade 6', 9),
(299, 'Computer', 500, 'Grade 6', 9),
(300, 'Medical', 200, 'Grade 7', 9),
(301, 'Insurance', 100, 'Grade 7', 9),
(302, 'Dental', 200, 'Grade 7', 9),
(303, 'Scouting', 200, 'Grade 7', 9),
(304, 'Instructional and Test Material', 400, 'Grade 7', 9),
(305, 'Library', 200, 'Grade 7', 9),
(306, 'Guidance', 500, 'Grade 7', 9),
(307, 'Development Fee', 600, 'Grade 7', 9),
(308, 'ID', 250, 'Grade 7', 9),
(309, 'Audio Visual', 300, 'Grade 7', 9),
(310, 'Aircon', 700, 'Grade 7', 9),
(311, 'Computer', 500, 'Grade 7', 9),
(312, 'Medical', 200, 'Grade 8', 9),
(313, 'Insurance', 100, 'Grade 8', 9),
(314, 'Dental', 200, 'Grade 8', 9),
(315, 'Scouting', 200, 'Grade 8', 9),
(316, 'Instructional and Test Material', 400, 'Grade 8', 9),
(317, 'Library', 200, 'Grade 8', 9),
(318, 'Guidance', 500, 'Grade 8', 9),
(319, 'Development Fee', 600, 'Grade 8', 9),
(320, 'ID', 250, 'Grade 8', 9),
(321, 'Audio Visual', 300, 'Grade 8', 9),
(322, 'Aircon', 700, 'Grade 8', 9),
(323, 'Computer', 500, 'Grade 8', 9),
(324, 'Medical', 200, 'Grade 9', 9),
(325, 'Insurance', 100, 'Grade 9', 9),
(326, 'Dental', 200, 'Grade 9', 9),
(327, 'Scouting', 200, 'Grade 9', 9),
(328, 'Instructional and Test Material', 400, 'Grade 9', 9),
(329, 'Library', 200, 'Grade 9', 9),
(330, 'Guidance', 500, 'Grade 9', 9),
(331, 'Development Fee', 600, 'Grade 9', 9),
(332, 'ID', 250, 'Grade 9', 9),
(333, 'Audio Visual', 300, 'Grade 9', 9),
(334, 'Aircon', 700, 'Grade 9', 9),
(335, 'Computer', 500, 'Grade 9', 9),
(336, 'Medical', 200, 'Grade 10', 9),
(337, 'Insurance', 200, 'Grade 10', 9),
(338, 'Dental', 200, 'Grade 10', 9),
(339, 'Scouting', 200, 'Grade 10', 9),
(340, 'Instructional and Test Material', 400, 'Grade 10', 9),
(341, 'Library', 200, 'Grade 10', 9),
(342, 'Guidance', 500, 'Grade 10', 9),
(343, 'Development Fee', 600, 'Grade 10', 9),
(344, 'ID', 250, 'Grade 10', 9),
(345, 'Audio Visual', 300, 'Grade 10', 9),
(346, 'Aircon', 700, 'Grade 10', 9),
(347, 'Computer', 500, 'Grade 10', 9),
(348, 'Medical', 200, 'Nursery', 8),
(349, 'Insurance', 100, 'Nursery', 8),
(350, 'Dental', 200, 'Nursery', 8),
(351, 'Scouting', 200, 'Nursery', 8),
(352, 'Instructional and Test Material', 400, 'Nursery', 8),
(353, 'Library', 200, 'Nursery', 8),
(354, 'Guidance', 500, 'Nursery', 8),
(355, 'Development Fee', 600, 'Nursery', 8),
(356, 'ID', 250, 'Nursery', 8),
(357, 'Audio Visual', 300, 'Nursery', 8),
(358, 'Aircon', 700, 'Nursery', 8),
(359, 'Computer', 500, 'Nursery', 8),
(360, 'Medical', 200, 'Junior Kinder', 8),
(361, 'Insurance', 100, 'Junior Kinder', 8),
(362, 'Dental', 200, 'Junior Kinder', 8),
(363, 'Scouting', 200, 'Junior Kinder', 8),
(364, 'Instructional and Test Material', 400, 'Junior Kinder', 8),
(365, 'Library', 200, 'Junior Kinder', 8),
(366, 'Guidance', 500, 'Junior Kinder', 8),
(367, 'Development Fee', 600, 'Junior Kinder', 8),
(368, 'ID', 250, 'Junior Kinder', 8),
(369, 'Audio Visual', 300, 'Junior Kinder', 8),
(370, 'Aircon', 700, 'Junior Kinder', 8),
(371, 'Computer', 500, 'Junior Kinder', 8),
(372, 'Insurance', 100, 'Senior Kinder', 8),
(373, 'Dental', 200, 'Senior Kinder', 8),
(374, 'Scouting', 200, 'Senior Kinder', 8),
(375, 'Instructional and Test Material', 400, 'Senior Kinder', 8),
(376, 'Library', 200, 'Senior Kinder', 8),
(377, 'Guidance', 500, 'Senior Kinder', 8),
(378, 'Development Fee', 600, 'Senior Kinder', 8),
(379, 'ID', 250, 'Senior Kinder', 8),
(380, 'Audio Visual', 300, 'Senior Kinder', 8),
(381, 'Aircon', 700, 'Senior Kinder', 8),
(382, 'Computer', 500, 'Senior Kinder', 8),
(383, 'Medical', 200, 'Grade 1', 8),
(384, 'Insurance', 100, 'Grade 1', 8),
(385, 'Dental', 200, 'Grade 1', 8),
(386, 'Scouting', 200, 'Grade 1', 8),
(387, 'Instructional and Test Material', 400, 'Grade 1', 8),
(388, 'Library', 200, 'Grade 1', 8),
(389, 'Guidance', 500, 'Grade 1', 8),
(390, 'Development Fee', 600, 'Grade 1', 8),
(391, 'ID', 250, 'Grade 1', 8),
(392, 'Audio Visual', 300, 'Grade 1', 8),
(393, 'Aircon', 700, 'Grade 1', 8),
(394, 'Computer', 500, 'Grade 1', 8),
(395, 'Medical', 200, 'Grade 2', 8),
(396, 'Insurance', 100, 'Grade 2', 8),
(397, 'Dental', 200, 'Grade 2', 8),
(398, 'Scouting', 200, 'Grade 2', 8),
(399, 'Instructional and Test Material', 400, 'Grade 2', 8),
(400, 'Library', 200, 'Grade 2', 8),
(401, 'Guidance', 500, 'Grade 2', 8),
(402, 'Development Fee', 600, 'Grade 2', 8),
(403, 'ID', 250, 'Grade 2', 8),
(404, 'Audio Visual', 300, 'Grade 2', 8),
(405, 'Aircon', 700, 'Grade 2', 8),
(406, 'Computer', 500, 'Grade 2', 8),
(407, 'Medical', 200, 'Grade 3', 8),
(408, 'Insurance', 100, 'Grade 3', 8),
(409, 'Dental', 200, 'Grade 3', 8),
(410, 'Scouting', 200, 'Grade 3', 8),
(411, 'Instructional and Test Material', 400, 'Grade 3', 8),
(412, 'Library', 200, 'Grade 3', 8),
(413, 'Guidance', 500, 'Grade 3', 8),
(414, 'Development Fee', 600, 'Grade 3', 8),
(415, 'ID', 250, 'Grade 3', 8),
(416, 'Audio Visual', 300, 'Grade 3', 8),
(417, 'Aircon', 700, 'Grade 3', 8),
(418, 'Computer', 500, 'Grade 3', 8),
(419, 'Medical', 200, 'Grade 4', 8),
(420, 'Insurance', 100, 'Grade 4', 8),
(421, 'Scouting', 200, 'Grade 4', 8),
(422, 'Instructional and Test Material', 400, 'Grade 4', 8),
(423, 'Guidance', 500, 'Grade 4', 8),
(424, 'Development Fee', 600, 'Grade 4', 8),
(425, 'ID', 250, 'Grade 4', 8),
(426, 'Audio Visual', 300, 'Grade 4', 8),
(427, 'Aircon', 700, 'Grade 4', 8),
(428, 'Computer', 500, 'Grade 4', 8),
(429, 'Medical', 200, 'Grade 5', 8),
(430, 'Insurance', 100, 'Grade 5', 8),
(431, 'Dental', 200, 'Grade 5', 8),
(432, 'Scouting', 200, 'Grade 5', 8),
(433, 'Instructional and Test Material', 400, 'Grade 5', 8),
(434, 'Library', 200, 'Grade 5', 8),
(435, 'Guidance', 500, 'Grade 5', 8),
(436, 'Development Fee', 600, 'Grade 5', 8),
(437, 'ID', 250, 'Grade 5', 8),
(439, 'Audio Visual', 300, 'Grade 5', 8),
(440, 'Aircon', 700, 'Grade 5', 8),
(441, 'Computer', 500, 'Grade 5', 8),
(442, 'Medical', 200, 'Grade 6', 8),
(443, 'Insurance', 100, 'Grade 6', 8),
(444, 'Dental', 200, 'Grade 6', 8),
(445, 'Scouting', 200, 'Grade 6', 8),
(446, 'Instructional and Test Material', 400, 'Grade 6', 8),
(447, 'Library', 200, 'Grade 6', 8),
(448, 'Guidance', 500, 'Grade 6', 8),
(449, 'Development Fee', 600, 'Grade 6', 8),
(450, 'ID', 250, 'Grade 6', 8),
(451, 'Audio Visual', 300, 'Grade 6', 8),
(452, 'Aircon', 700, 'Grade 6', 8),
(453, 'Computer', 500, 'Grade 6', 8),
(454, 'Medical', 200, 'Grade 7', 8),
(455, 'Insurance', 100, 'Grade 7', 8),
(456, 'Dental', 200, 'Grade 7', 8),
(457, 'Scouting', 200, 'Grade 7', 8),
(458, 'Instructional and Test Material', 400, 'Grade 7', 8),
(459, 'Library', 200, 'Grade 7', 8),
(460, 'Guidance', 500, 'Grade 7', 8),
(461, 'Development Fee', 600, 'Grade 7', 8),
(462, 'ID', 250, 'Grade 7', 8),
(463, 'Audio Visual', 300, 'Grade 7', 8),
(464, 'Aircon', 700, 'Grade 7', 8),
(465, 'Computer', 500, 'Grade 7', 8),
(466, 'Medical', 200, 'Grade 8', 8),
(467, 'Insurance', 100, 'Grade 8', 8),
(468, 'Dental', 200, 'Grade 8', 8),
(469, 'Scouting', 200, 'Grade 8', 8),
(470, 'Instructional and Test Material', 400, 'Grade 8', 8),
(471, 'Library', 200, 'Grade 8', 8),
(472, 'Guidance', 500, 'Grade 8', 8),
(473, 'Development Fee', 600, 'Grade 8', 8),
(474, 'ID', 250, 'Grade 8', 8),
(475, 'Audio Visual', 300, 'Grade 8', 8),
(476, 'Aircon', 700, 'Grade 8', 8),
(477, 'Computer', 500, 'Grade 8', 8),
(478, 'Medical', 200, 'Grade 9', 8),
(479, 'Insurance', 100, 'Grade 9', 8),
(480, 'Dental', 200, 'Grade 9', 8),
(481, 'Scouting', 200, 'Grade 9', 8),
(482, 'Instructional and Test Material', 400, 'Grade 9', 8),
(483, 'Library', 200, 'Grade 9', 8),
(484, 'Guidance', 500, 'Grade 9', 8),
(485, 'Development Fee', 600, 'Grade 9', 8),
(486, 'ID', 250, 'Grade 9', 8),
(487, 'Audio Visual', 300, 'Grade 9', 8),
(488, 'Aircon', 700, 'Grade 9', 8),
(489, 'Computer', 500, 'Grade 9', 8),
(490, 'Medical', 200, 'Grade 10', 8),
(491, 'Insurance', 100, 'Grade 10', 8),
(492, 'Dental', 200, 'Grade 10', 8),
(493, 'Scouting', 200, 'Grade 10', 8),
(494, 'Instructional and Test Material', 400, 'Grade 10', 8),
(495, 'Library', 200, 'Grade 10', 8),
(496, 'Guidance', 500, 'Grade 10', 8),
(497, 'Development Fee', 600, 'Grade 10', 8),
(498, 'ID', 250, 'Grade 10', 8),
(499, 'Audio Visual', 300, 'Grade 10', 8),
(500, 'Aircon', 700, 'Grade 10', 8),
(501, 'Computer', 500, 'Grade 10', 8);

-- --------------------------------------------------------

--
-- Table structure for table `orno`
--

CREATE TABLE `orno` (
  `orNo` int(11) NOT NULL,
  `oror` varchar(100) NOT NULL,
  `sno` varchar(255) NOT NULL,
  `amount` float NOT NULL,
  `date_pay` varchar(100) NOT NULL,
  `syid` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `orno`
--

INSERT INTO `orno` (`orNo`, `oror`, `sno`, `amount`, `date_pay`, `syid`) VALUES
(17, 'OR#18', 'STUD-2019-0069', 18907, '08/08/2020', 1),
(18, 'OR#19', 'STUD-2019-0070', 5000, '08/08/2020', 1),
(19, 'OR#20', 'STUD-2019-0070', 4603.5, '08/08/2020', 1),
(20, 'OR#21', 'STUD-2019-0071', 16820, '08/08/2020', 1),
(21, 'OR#22', 'STUD-2019-0072', 16820, '08/08/2020', 1),
(22, 'OR#23', 'STUD-2020-0073', 8560, '08/08/2020', 9),
(23, 'OR#24', 'STUD-2019-0001', 16186.5, '11/08/2020', 1),
(24, 'OR#25', 'STUD-2019-0002', 16820, '11/08/2020', 1),
(25, 'OR#26', 'STUD-2019-0003', 16820, '11/08/2020', 1),
(26, 'OR#27', 'STUD-2019-0005', 5500, '11/08/2020', 1),
(27, 'OR#28', 'STUD-2019-0006', 1000, '11/08/2020', 1),
(28, 'OR#29', 'STUD-2019-0007', 16186.5, '12/08/2020', 1),
(29, 'OR#30', 'STUD-2019-0008', 8560, '12/08/2020', 1),
(30, 'OR#31', 'STUD-2019-0006', 7560, '12/08/2020', 1),
(31, 'OR#32', 'STUD-2019-0009', 16820, '12/08/2020', 1),
(32, 'OR#33', 'STUD-2019-0010', 1000, '12/08/2020', 1),
(33, 'OR#34', 'STUD-2019-0010', 15820, '12/08/2020', 1),
(34, 'OR#35', 'STUD-2019-0013', 16820, '12/08/2020', 1),
(35, 'OR#36', 'STUD-2019-0014', 16820, '12/08/2020', 1),
(36, 'OR#37', 'STUD-2019-0001', 16820, '12/08/2020', 9),
(37, 'OR#38', 'STUD-2019-0002', 16820, '12/08/2020', 9),
(38, 'OR#39', 'STUD-2019-0003', 16820, '12/08/2020', 9),
(39, 'OR#40', 'STUD-2019-0006', 16820, '12/08/2020', 9),
(40, 'OR#41', 'STUD-2019-0015', 16186.5, '12/08/2020', 1),
(41, 'OR#42', 'STUD-2019-0016', 16186.5, '12/08/2020', 1),
(42, 'OR#43', 'STUD-2019-0005', 16820, '13/08/2020', 8),
(43, 'OR#44', 'STUD-2019-0008', 8560, '13/08/2020', 8),
(44, 'OR#45', 'STUD-2019-0015', 8560, '13/08/2020', 8),
(45, 'OR#46', 'STUD-2019-0016', 5500, '13/08/2020', 8),
(46, 'OR#47', 'STUD-2019-0007', 16820, '13/08/2020', 8),
(47, 'OR#48', 'STUD-2019-0009', 16820, '13/08/2020', 9),
(48, 'OR#49', 'STUD-2019-0013', 16820, '13/08/2020', 9),
(49, 'OR#50', 'STUD-2019-0017', 4455, '21/08/2020', 1),
(50, 'OR#51', 'STUD-2019-0018', 8560, '21/08/2020', 1),
(51, 'OR#52', 'STUD-2019-0019', 8560, '21/08/2020', 1),
(52, 'OR#53', 'STUD-2019-0020', 4455, '21/08/2020', 1),
(53, 'OR#54', 'STUD-2019-0021', 14919.5, '21/08/2020', 1),
(54, 'OR#55', 'STUD-2019-0022', 22260, '28/08/2020', 1),
(55, 'OR#56', 'STUD-2019-0023', 23250, '28/08/2020', 1),
(56, 'OR#57', 'STUD-2019-0023', 25150, '28/08/2020', 9),
(57, 'OR#58', 'STUD-2019-0022', 25150, '28/08/2020', 9);

-- --------------------------------------------------------

--
-- Table structure for table `sched_section`
--

CREATE TABLE `sched_section` (
  `ss_id` int(11) NOT NULL,
  `timestamp_id` int(11) NOT NULL,
  `subject_id` int(11) NOT NULL,
  `teacher_ID` int(11) NOT NULL,
  `classroom_id` int(11) NOT NULL,
  `sect_id` int(11) NOT NULL,
  `SY_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sched_section`
--

INSERT INTO `sched_section` (`ss_id`, `timestamp_id`, `subject_id`, `teacher_ID`, `classroom_id`, `sect_id`, `SY_id`) VALUES
(1, 1, 66, 58, 1, 1, 1),
(2, 2, 67, 58, 1, 1, 1),
(3, 3, 68, 58, 1, 1, 1),
(4, 4, 69, 58, 1, 1, 1),
(5, 5, 70, 58, 1, 1, 1),
(6, 1, 66, 32, 2, 2, 1),
(7, 2, 67, 32, 2, 2, 1),
(8, 3, 68, 32, 2, 2, 1),
(9, 4, 69, 32, 2, 2, 1),
(10, 5, 70, 32, 2, 2, 1),
(11, 1, 117, 73, 3, 3, 1),
(12, 2, 116, 73, 3, 3, 1),
(13, 3, 118, 73, 3, 3, 1),
(14, 4, 119, 73, 3, 3, 1),
(15, 5, 120, 73, 3, 3, 1),
(16, 1, 116, 33, 4, 5, 1),
(17, 2, 117, 33, 4, 5, 1),
(18, 3, 119, 33, 4, 5, 1),
(19, 4, 118, 33, 4, 5, 1),
(20, 5, 120, 33, 4, 5, 1),
(21, 1, 121, 34, 5, 6, 1),
(22, 2, 122, 34, 5, 6, 1),
(23, 3, 123, 34, 5, 6, 1),
(24, 4, 124, 34, 5, 6, 1),
(25, 5, 125, 34, 5, 6, 1),
(26, 1, 121, 35, 6, 7, 1),
(27, 2, 122, 35, 6, 7, 1),
(28, 3, 123, 35, 6, 7, 1),
(29, 4, 124, 35, 6, 7, 1),
(30, 5, 125, 35, 6, 7, 1),
(31, 10, 101, 52, 1, 20, 1),
(32, 11, 102, 47, 1, 20, 1),
(33, 12, 103, 44, 1, 20, 1),
(34, 16, 104, 42, 1, 20, 1),
(35, 17, 105, 50, 1, 20, 1),
(36, 18, 106, 46, 1, 20, 1),
(37, 19, 107, 54, 1, 20, 1),
(38, 15, 108, 56, 1, 20, 1),
(47, 10, 101, 53, 2, 21, 1),
(48, 11, 102, 49, 2, 21, 1),
(49, 12, 103, 45, 2, 21, 1),
(50, 15, 104, 42, 2, 21, 1),
(51, 16, 105, 50, 2, 21, 1),
(52, 17, 106, 46, 2, 21, 1),
(53, 18, 107, 54, 2, 21, 1),
(54, 19, 108, 56, 2, 21, 1),
(55, 10, 109, 47, 3, 22, 1),
(56, 11, 111, 42, 3, 22, 1),
(57, 12, 110, 66, 3, 22, 1),
(58, 15, 112, 50, 3, 22, 1),
(59, 16, 113, 46, 3, 22, 1),
(60, 17, 114, 54, 3, 22, 1),
(61, 18, 115, 52, 3, 22, 1),
(62, 10, 109, 49, 4, 23, 1),
(63, 11, 110, 44, 4, 23, 1),
(64, 12, 111, 42, 4, 23, 1),
(65, 15, 112, 51, 4, 23, 1),
(66, 16, 113, 48, 4, 23, 1),
(67, 17, 114, 55, 4, 23, 1),
(68, 18, 115, 53, 4, 23, 1),
(69, 10, 133, 42, 5, 24, 1),
(70, 11, 134, 45, 5, 24, 1),
(71, 12, 135, 46, 5, 24, 1),
(72, 15, 136, 47, 5, 24, 1),
(73, 16, 137, 51, 5, 24, 1),
(74, 10, 133, 43, 6, 25, 1),
(75, 11, 134, 66, 6, 25, 1),
(76, 12, 135, 48, 6, 25, 1),
(77, 15, 136, 49, 6, 25, 1),
(78, 16, 137, 70, 6, 25, 1),
(79, 2, 71, 54, 9, 8, 1),
(80, 1, 72, 54, 9, 8, 1),
(81, 3, 73, 54, 9, 8, 1),
(82, 4, 74, 54, 9, 8, 1),
(83, 5, 75, 54, 9, 8, 1),
(84, 6, 76, 54, 9, 8, 1),
(85, 9, 71, 38, 14, 9, 1),
(86, 10, 72, 38, 14, 9, 1),
(87, 11, 73, 38, 14, 9, 1),
(88, 15, 74, 38, 14, 9, 1),
(89, 12, 75, 38, 14, 9, 1),
(90, 16, 76, 38, 14, 9, 1),
(91, 1, 77, 36, 7, 10, 1),
(92, 2, 78, 36, 7, 10, 1),
(93, 3, 79, 36, 7, 10, 1),
(94, 4, 80, 36, 7, 10, 1),
(95, 5, 81, 36, 7, 10, 1),
(96, 6, 82, 36, 7, 10, 1),
(97, 9, 77, 75, 7, 11, 1),
(98, 10, 78, 75, 7, 11, 1),
(99, 11, 79, 75, 7, 11, 1),
(100, 12, 80, 75, 7, 11, 1),
(101, 15, 81, 75, 7, 11, 1),
(102, 16, 82, 75, 7, 11, 1),
(103, 1, 83, 76, 10, 12, 1),
(104, 2, 84, 76, 10, 12, 1),
(105, 3, 85, 76, 10, 12, 1),
(106, 4, 86, 76, 10, 12, 1),
(107, 5, 87, 76, 10, 12, 1),
(108, 6, 88, 76, 10, 12, 1),
(109, 9, 83, 34, 8, 13, 1),
(110, 10, 84, 34, 8, 13, 1),
(111, 11, 85, 34, 8, 13, 1),
(112, 12, 86, 34, 8, 13, 1),
(113, 15, 87, 34, 8, 13, 1),
(114, 16, 88, 34, 8, 13, 1),
(115, 1, 89, 62, 8, 14, 1),
(116, 2, 90, 62, 8, 14, 1),
(117, 3, 91, 62, 8, 14, 1),
(118, 4, 92, 62, 8, 14, 1),
(119, 5, 93, 62, 8, 14, 1),
(120, 7, 94, 62, 8, 14, 1),
(121, 6, 95, 62, 8, 14, 1),
(122, 9, 89, 77, 9, 15, 1),
(123, 10, 90, 77, 9, 15, 1),
(124, 11, 91, 77, 9, 15, 1),
(125, 12, 92, 77, 9, 15, 1),
(126, 15, 93, 77, 9, 15, 1),
(127, 16, 94, 77, 9, 15, 1),
(128, 17, 95, 77, 9, 15, 1),
(129, 1, 96, 78, 11, 16, 1),
(130, 2, 97, 78, 11, 16, 1),
(131, 3, 98, 78, 11, 16, 1),
(132, 4, 99, 78, 11, 16, 1),
(133, 5, 100, 78, 11, 16, 1),
(134, 9, 96, 32, 10, 17, 1),
(135, 10, 97, 32, 10, 17, 1),
(136, 11, 98, 32, 10, 17, 1),
(137, 12, 100, 32, 10, 17, 1),
(138, 15, 99, 32, 10, 17, 1),
(139, 1, 126, 41, 12, 18, 1),
(140, 2, 127, 41, 12, 18, 1),
(141, 3, 128, 41, 12, 18, 1),
(142, 4, 129, 41, 12, 18, 1),
(143, 5, 130, 41, 12, 18, 1),
(144, 6, 131, 41, 12, 18, 1),
(145, 7, 132, 41, 12, 18, 1),
(146, 9, 126, 78, 11, 19, 1),
(147, 10, 127, 78, 11, 19, 1),
(148, 11, 128, 78, 11, 19, 1),
(149, 12, 129, 78, 11, 19, 1),
(150, 15, 131, 78, 11, 19, 1),
(151, 16, 130, 78, 11, 19, 1),
(152, 17, 132, 78, 11, 19, 1),
(153, 10, 138, 65, 12, 26, 1),
(154, 11, 139, 76, 12, 26, 1),
(155, 12, 140, 68, 12, 26, 1),
(156, 15, 141, 69, 12, 26, 1),
(157, 16, 142, 53, 12, 26, 1),
(158, 10, 138, 73, 13, 27, 1),
(159, 11, 139, 84, 13, 27, 1),
(160, 12, 140, 67, 13, 27, 1),
(161, 16, 142, 52, 13, 27, 1),
(162, 15, 141, 69, 13, 27, 1),
(163, 1, 66, 58, 5, 28, 9),
(164, 2, 67, 58, 5, 28, 9),
(165, 3, 68, 58, 5, 28, 9),
(166, 4, 69, 58, 5, 28, 9),
(167, 5, 70, 58, 5, 28, 9),
(168, 6, 66, 58, 5, 29, 9),
(169, 7, 67, 58, 5, 29, 9),
(170, 8, 68, 58, 5, 29, 9),
(171, 9, 69, 58, 5, 29, 9),
(172, 10, 70, 58, 5, 29, 9),
(173, 1, 116, 32, 6, 30, 9),
(174, 2, 117, 32, 6, 30, 9),
(175, 3, 118, 32, 6, 30, 9),
(176, 4, 119, 32, 6, 30, 9),
(177, 5, 120, 32, 6, 30, 9),
(178, 6, 116, 32, 6, 31, 9),
(179, 7, 117, 32, 6, 31, 9),
(180, 8, 118, 32, 6, 31, 9),
(181, 9, 119, 32, 6, 31, 9),
(182, 10, 120, 32, 6, 31, 9),
(183, 1, 121, 73, 7, 32, 9),
(184, 2, 122, 73, 7, 32, 9),
(185, 3, 123, 73, 7, 32, 9),
(186, 4, 124, 73, 7, 32, 9),
(187, 5, 125, 73, 7, 32, 9),
(188, 6, 122, 73, 10, 33, 9),
(189, 7, 121, 73, 10, 33, 9),
(190, 8, 123, 73, 10, 33, 9),
(191, 9, 124, 73, 10, 33, 9),
(192, 10, 125, 73, 10, 33, 9),
(193, 1, 71, 33, 16, 34, 9),
(194, 2, 72, 33, 16, 34, 9),
(195, 3, 73, 33, 16, 34, 9),
(196, 4, 74, 33, 16, 34, 9),
(197, 5, 75, 33, 16, 34, 9),
(198, 6, 76, 33, 16, 34, 9),
(199, 7, 71, 33, 11, 35, 9),
(200, 8, 72, 33, 11, 35, 9),
(201, 9, 73, 33, 11, 35, 9),
(202, 10, 74, 33, 11, 35, 9),
(203, 11, 75, 33, 11, 35, 9),
(204, 12, 76, 33, 11, 35, 9),
(205, 1, 77, 34, 21, 36, 9),
(206, 2, 78, 34, 21, 36, 9),
(207, 3, 79, 34, 21, 36, 9),
(208, 4, 80, 34, 21, 36, 9),
(209, 5, 81, 34, 21, 36, 9),
(210, 6, 82, 34, 21, 36, 9),
(211, 7, 77, 34, 20, 37, 9),
(212, 8, 78, 34, 20, 37, 9),
(213, 9, 79, 34, 20, 37, 9),
(214, 10, 80, 34, 20, 37, 9),
(215, 11, 81, 34, 20, 37, 9),
(216, 12, 82, 34, 20, 37, 9),
(217, 1, 83, 35, 2, 38, 9),
(218, 2, 85, 35, 2, 38, 9),
(219, 3, 84, 35, 2, 38, 9),
(220, 4, 86, 35, 2, 38, 9),
(221, 5, 87, 35, 2, 38, 9),
(222, 6, 88, 35, 2, 38, 9),
(223, 7, 83, 35, 19, 39, 9),
(224, 8, 85, 35, 19, 39, 9),
(225, 9, 87, 35, 19, 39, 9),
(226, 10, 84, 35, 19, 39, 9),
(227, 11, 86, 35, 19, 39, 9),
(228, 12, 88, 35, 19, 39, 9),
(229, 1, 89, 36, 1, 40, 9),
(230, 2, 90, 36, 1, 40, 9),
(231, 3, 91, 36, 1, 40, 9),
(232, 4, 92, 36, 1, 40, 9),
(233, 5, 93, 36, 1, 40, 9),
(234, 6, 94, 36, 1, 40, 9),
(235, 7, 95, 36, 1, 40, 9),
(236, 8, 90, 36, 21, 41, 9),
(237, 9, 89, 36, 21, 41, 9),
(238, 10, 91, 36, 21, 41, 9),
(239, 11, 92, 36, 21, 41, 9),
(240, 12, 93, 36, 21, 41, 9),
(241, 15, 94, 36, 21, 41, 9),
(242, 16, 95, 36, 21, 41, 9),
(243, 1, 96, 78, 3, 42, 9),
(244, 2, 97, 78, 3, 42, 9),
(245, 4, 98, 78, 3, 42, 9),
(246, 3, 99, 78, 3, 42, 9),
(247, 5, 100, 78, 3, 42, 9),
(248, 9, 96, 74, 3, 43, 9),
(249, 10, 97, 74, 3, 43, 9),
(250, 11, 98, 74, 3, 43, 9),
(251, 12, 99, 74, 3, 43, 9),
(252, 15, 100, 74, 3, 43, 9),
(253, 1, 126, 77, 4, 44, 9),
(254, 2, 127, 77, 4, 44, 9),
(255, 3, 128, 77, 4, 44, 9),
(256, 4, 129, 77, 4, 44, 9),
(257, 6, 130, 77, 4, 44, 9),
(258, 5, 131, 77, 4, 44, 9),
(259, 7, 132, 77, 4, 44, 9),
(260, 9, 126, 37, 1, 45, 9),
(261, 10, 127, 37, 1, 45, 9),
(262, 11, 128, 37, 1, 45, 9),
(263, 12, 129, 37, 1, 45, 9),
(264, 15, 130, 37, 1, 45, 9),
(265, 14, 131, 37, 1, 45, 9),
(266, 16, 132, 37, 1, 45, 9),
(267, 1, 101, 52, 8, 46, 9),
(268, 2, 102, 47, 8, 46, 9),
(269, 3, 103, 76, 8, 46, 9),
(270, 4, 104, 65, 8, 46, 9),
(271, 5, 105, 51, 8, 46, 9),
(272, 6, 106, 67, 8, 46, 9),
(273, 7, 107, 54, 8, 46, 9),
(274, 8, 108, 83, 8, 46, 9),
(275, 9, 101, 53, 2, 47, 9),
(276, 10, 102, 47, 2, 47, 9),
(277, 11, 103, 44, 2, 47, 9),
(278, 12, 104, 43, 2, 47, 9),
(279, 15, 105, 51, 2, 47, 9),
(280, 17, 106, 48, 2, 47, 9),
(281, 16, 107, 82, 2, 47, 9),
(282, 19, 108, 57, 2, 47, 9),
(283, 1, 109, 47, 9, 48, 9),
(284, 2, 110, 44, 9, 48, 9),
(285, 3, 111, 43, 9, 48, 9),
(286, 4, 112, 50, 9, 48, 9),
(287, 5, 113, 46, 9, 48, 9),
(288, 6, 114, 54, 9, 48, 9),
(289, 7, 115, 52, 9, 48, 9),
(290, 9, 109, 49, 4, 49, 9),
(291, 11, 110, 66, 4, 49, 9),
(292, 12, 111, 73, 4, 49, 9),
(293, 15, 113, 70, 4, 49, 9),
(294, 16, 112, 70, 4, 49, 9),
(295, 17, 114, 55, 4, 49, 9),
(296, 18, 115, 80, 4, 49, 9),
(297, 1, 133, 43, 11, 50, 9),
(298, 2, 134, 45, 11, 50, 9),
(299, 3, 135, 67, 11, 50, 9),
(300, 4, 136, 69, 11, 50, 9),
(301, 5, 137, 70, 11, 50, 9),
(302, 6, 133, 42, 7, 51, 9),
(303, 7, 134, 66, 7, 51, 9),
(304, 8, 135, 48, 7, 51, 9),
(305, 9, 136, 69, 7, 51, 9),
(306, 10, 137, 70, 7, 51, 9),
(307, 1, 138, 75, 13, 52, 9),
(308, 2, 139, 76, 13, 52, 9),
(309, 3, 140, 68, 13, 52, 9),
(310, 4, 141, 47, 13, 52, 9),
(311, 5, 142, 53, 13, 52, 9),
(312, 6, 138, 74, 13, 53, 9),
(313, 7, 139, 45, 13, 53, 9),
(314, 8, 140, 67, 13, 53, 9),
(315, 9, 141, 78, 13, 53, 9),
(316, 10, 142, 52, 13, 53, 9),
(317, 1, 66, 58, 1, 54, 8),
(318, 2, 67, 58, 1, 54, 8),
(319, 3, 68, 58, 1, 54, 8),
(320, 4, 69, 58, 1, 54, 8),
(321, 5, 70, 58, 1, 54, 8),
(322, 1, 66, 32, 2, 55, 8),
(323, 2, 67, 32, 2, 55, 8),
(324, 3, 68, 32, 2, 55, 8),
(325, 4, 69, 32, 2, 55, 8),
(326, 5, 70, 32, 2, 55, 8),
(327, 1, 116, 73, 3, 56, 8),
(328, 2, 117, 73, 3, 56, 8),
(329, 3, 118, 73, 3, 56, 8),
(330, 4, 119, 73, 3, 56, 8),
(331, 5, 120, 73, 3, 56, 8),
(332, 1, 116, 33, 4, 57, 8),
(333, 2, 117, 33, 4, 57, 8),
(334, 3, 118, 33, 4, 57, 8),
(335, 4, 119, 33, 4, 57, 8),
(336, 5, 120, 33, 4, 57, 8),
(337, 1, 121, 34, 5, 58, 8),
(338, 2, 122, 34, 5, 58, 8),
(339, 3, 123, 34, 5, 58, 8),
(340, 4, 124, 34, 5, 58, 8),
(341, 5, 125, 34, 5, 58, 8),
(342, 1, 121, 35, 6, 59, 8),
(343, 2, 122, 35, 6, 59, 8),
(344, 3, 123, 35, 6, 59, 8),
(345, 4, 124, 35, 6, 59, 8),
(346, 5, 125, 35, 6, 59, 8),
(347, 10, 101, 52, 1, 72, 8),
(348, 11, 102, 47, 1, 72, 8),
(349, 12, 103, 44, 1, 72, 8),
(350, 16, 104, 42, 1, 72, 8),
(351, 17, 105, 50, 1, 72, 8),
(352, 18, 106, 46, 1, 72, 8),
(353, 19, 107, 54, 1, 72, 8),
(354, 15, 108, 72, 1, 72, 8),
(355, 10, 101, 53, 2, 73, 8),
(356, 11, 102, 49, 2, 73, 8),
(357, 12, 103, 45, 2, 73, 8),
(358, 15, 104, 43, 2, 73, 8),
(359, 16, 105, 51, 2, 73, 8),
(360, 17, 106, 48, 2, 73, 8),
(361, 18, 107, 55, 2, 73, 8),
(362, 19, 108, 57, 2, 73, 8),
(363, 10, 109, 47, 3, 74, 8),
(364, 11, 110, 44, 3, 74, 8),
(365, 12, 111, 42, 3, 74, 8),
(366, 15, 112, 50, 3, 74, 8),
(367, 16, 113, 46, 3, 74, 8),
(368, 17, 114, 54, 3, 74, 8),
(369, 18, 115, 52, 3, 74, 8),
(370, 10, 109, 49, 4, 75, 8),
(371, 11, 110, 45, 4, 75, 8),
(372, 12, 111, 43, 4, 75, 8),
(373, 15, 112, 51, 4, 75, 8),
(374, 16, 113, 48, 4, 75, 8),
(375, 17, 114, 55, 4, 75, 8),
(376, 18, 115, 53, 4, 75, 8),
(377, 10, 133, 42, 5, 76, 8),
(378, 11, 134, 66, 5, 76, 8),
(379, 15, 135, 46, 5, 76, 8),
(380, 16, 136, 47, 5, 76, 8),
(381, 17, 137, 70, 5, 76, 8),
(382, 10, 133, 43, 6, 77, 8),
(383, 11, 134, 76, 6, 77, 8),
(384, 12, 135, 48, 6, 77, 8),
(385, 15, 136, 78, 6, 77, 8),
(386, 16, 137, 79, 6, 77, 8),
(387, 10, 138, 65, 7, 78, 8),
(388, 11, 139, 84, 7, 78, 8),
(389, 12, 140, 67, 7, 78, 8),
(390, 15, 141, 69, 7, 78, 8),
(391, 16, 142, 52, 7, 78, 8),
(392, 10, 138, 73, 8, 79, 8),
(393, 11, 140, 46, 8, 79, 8),
(394, 12, 141, 47, 8, 79, 8),
(395, 15, 142, 52, 8, 79, 8),
(396, 16, 139, 44, 8, 79, 8),
(397, 1, 71, 36, 7, 60, 8),
(398, 2, 72, 36, 7, 60, 8),
(399, 3, 73, 36, 7, 60, 8),
(400, 4, 74, 36, 7, 60, 8),
(401, 5, 75, 36, 7, 60, 8),
(402, 6, 76, 36, 7, 60, 8),
(403, 7, 71, 34, 9, 61, 8),
(404, 8, 72, 34, 9, 61, 8),
(405, 9, 73, 34, 9, 61, 8),
(406, 10, 74, 34, 9, 61, 8),
(407, 11, 75, 34, 9, 61, 8),
(408, 12, 76, 34, 9, 61, 8),
(409, 1, 77, 37, 8, 62, 8),
(410, 2, 78, 37, 8, 62, 8),
(411, 3, 79, 37, 8, 62, 8),
(412, 4, 80, 37, 8, 62, 8),
(413, 5, 81, 37, 8, 62, 8),
(414, 6, 82, 37, 8, 62, 8),
(415, 7, 77, 37, 10, 63, 8),
(416, 8, 78, 37, 10, 63, 8),
(417, 9, 79, 37, 10, 63, 8),
(418, 10, 80, 37, 10, 63, 8),
(419, 11, 81, 37, 10, 63, 8),
(420, 12, 82, 37, 10, 63, 8),
(421, 1, 83, 74, 11, 64, 8),
(422, 2, 84, 74, 11, 64, 8),
(423, 3, 85, 74, 11, 64, 8),
(424, 4, 86, 74, 11, 64, 8),
(425, 5, 87, 74, 11, 64, 8),
(426, 6, 88, 74, 11, 64, 8),
(427, 7, 83, 74, 12, 65, 8),
(428, 8, 85, 74, 12, 65, 8),
(429, 9, 84, 74, 12, 65, 8),
(430, 10, 86, 74, 12, 65, 8),
(431, 11, 87, 74, 12, 65, 8),
(432, 12, 88, 74, 12, 65, 8),
(433, 1, 89, 75, 13, 66, 8),
(434, 2, 90, 75, 13, 66, 8),
(435, 3, 91, 75, 13, 66, 8),
(436, 4, 92, 75, 13, 66, 8),
(437, 5, 94, 75, 13, 66, 8),
(438, 6, 93, 75, 13, 66, 8),
(439, 7, 95, 75, 13, 66, 8),
(440, 8, 89, 38, 11, 67, 8),
(441, 9, 90, 38, 11, 67, 8),
(442, 10, 91, 38, 11, 67, 8),
(443, 11, 92, 38, 11, 67, 8),
(444, 12, 93, 38, 11, 67, 8),
(445, 15, 94, 38, 11, 67, 8),
(446, 16, 95, 38, 11, 67, 8),
(447, 1, 96, 59, 9, 70, 8),
(448, 2, 97, 59, 9, 70, 8),
(449, 3, 98, 59, 9, 70, 8),
(450, 4, 99, 59, 9, 70, 8),
(451, 5, 100, 59, 9, 70, 8),
(452, 6, 96, 59, 17, 71, 8),
(453, 7, 97, 59, 17, 71, 8),
(454, 8, 98, 59, 17, 71, 8),
(455, 9, 99, 59, 17, 71, 8),
(456, 10, 100, 59, 17, 71, 8),
(457, 1, 126, 60, 14, 68, 8),
(458, 2, 127, 60, 14, 68, 8),
(459, 3, 128, 60, 14, 68, 8),
(460, 4, 129, 60, 14, 68, 8),
(461, 5, 130, 60, 14, 68, 8),
(462, 6, 131, 60, 14, 68, 8),
(463, 7, 132, 60, 14, 68, 8),
(464, 8, 126, 60, 13, 69, 8),
(465, 9, 127, 60, 13, 69, 8),
(466, 10, 128, 60, 13, 69, 8),
(467, 11, 129, 60, 13, 69, 8),
(468, 15, 130, 60, 13, 69, 8),
(469, 16, 131, 60, 13, 69, 8),
(470, 17, 132, 60, 13, 69, 8);

-- --------------------------------------------------------

--
-- Table structure for table `school_requirements`
--

CREATE TABLE `school_requirements` (
  `req_id` int(11) NOT NULL,
  `type_of_student` text NOT NULL,
  `requirement_name` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `school_requirements`
--

INSERT INTO `school_requirements` (`req_id`, `type_of_student`, `requirement_name`) VALUES
(24, 'New Student', 'Birth Certificate PSA'),
(25, 'Transferee Student', 'Good Moral'),
(26, 'Old Student', 'Form 138'),
(27, 'Transferee Student', 'Form 137'),
(28, 'Transferee Student', 'Form 138'),
(29, 'Returnee Student', 'Form 138'),
(30, 'New Student', 'Barangay Clearance');

-- --------------------------------------------------------

--
-- Table structure for table `school_year`
--

CREATE TABLE `school_year` (
  `id` int(11) NOT NULL,
  `school_year` varchar(9) NOT NULL,
  `sy_status` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `school_year`
--

INSERT INTO `school_year` (`id`, `school_year`, `sy_status`) VALUES
(1, '2018-2019', 'activate'),
(8, '2020-2021', 'deactivate'),
(9, '2019-2020', 'deactivate');

-- --------------------------------------------------------

--
-- Table structure for table `sections`
--

CREATE TABLE `sections` (
  `sect_id` int(11) NOT NULL,
  `grade_level` text NOT NULL,
  `teacher_ID` int(11) NOT NULL,
  `section_name` text NOT NULL,
  `limit_capacity` int(11) DEFAULT NULL,
  `SY_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sections`
--

INSERT INTO `sections` (`sect_id`, `grade_level`, `teacher_ID`, `section_name`, `limit_capacity`, `SY_ID`) VALUES
(1, 'Nursery', 58, 'Sunflower', 5, 1),
(2, 'Nursery', 32, 'Lily', 5, 1),
(3, 'Junior Kinder', 73, 'Rose', 2, 1),
(5, 'Junior Kinder', 33, 'Gumamela', 2, 1),
(6, 'Senior Kinder', 34, 'Sampaguita', 15, 1),
(7, 'Senior Kinder', 35, 'Tulip', 15, 1),
(8, 'Grade 1', 36, 'Blue', 15, 1),
(9, 'Grade 1', 37, 'Red', 15, 1),
(10, 'Grade 2', 74, 'Orange', 15, 1),
(11, 'Grade 2', 75, 'Yellow', 15, 1),
(12, 'Grade 3', 38, 'Pink', 15, 1),
(13, 'Grade 3', 59, 'Green', 15, 1),
(14, 'Grade 4', 58, 'Black', 15, 1),
(15, 'Grade 4', 32, 'Brown', 15, 1),
(16, 'Grade 5', 73, 'Gold', 15, 1),
(17, 'Grade 5', 33, 'Silver', 15, 1),
(18, 'Grade 6', 34, 'Copper', 15, 1),
(19, 'Grade 6', 35, 'Diamond', 15, 1),
(20, 'Grade 7', 42, 'Socrates', 15, 1),
(21, 'Grade 7', 43, 'Plato', 15, 1),
(22, 'Grade 8', 44, 'Aristotle', 15, 1),
(23, 'Grade 8', 45, 'Aquinas', 15, 1),
(24, 'Grade 9', 51, 'Hobbes', 15, 1),
(25, 'Grade 9', 67, 'Marx', 15, 1),
(26, 'Grade 10', 53, 'Hume', 15, 1),
(27, 'Grade 10', 66, 'Kant', 15, 1),
(28, 'Nursery', 58, 'Sunflower', 15, 9),
(29, 'Nursery', 32, 'Lily', 15, 9),
(30, 'Junior Kinder', 73, 'Gumamela', 15, 9),
(31, 'Junior Kinder', 73, 'Rose', 15, 9),
(32, 'Senior Kinder', 33, 'Sampaguita', 15, 9),
(33, 'Senior Kinder', 34, 'Tulip', 15, 9),
(34, 'Grade 1', 35, 'Blue', 15, 9),
(35, 'Grade 1', 36, 'Orange', 15, 9),
(36, 'Grade 2', 35, 'Pink', 15, 9),
(37, 'Grade 2', 74, 'Brown', 15, 9),
(38, 'Grade 3', 59, 'Black', 15, 9),
(39, 'Grade 3', 76, 'Green', 15, 9),
(40, 'Grade 4', 38, 'Red', 15, 9),
(41, 'Grade 4', 36, 'Yellow', 15, 9),
(42, 'Grade 5', 33, 'Gold', 15, 9),
(43, 'Grade 5', 58, 'Silver', 15, 9),
(44, 'Grade 6', 35, 'Copper', 15, 9),
(45, 'Grade 6', 76, 'Diamond', 15, 9),
(46, 'Grade 7', 66, 'Plato', 15, 9),
(47, 'Grade 7', 72, 'Socrates', 15, 9),
(48, 'Grade 8', 49, 'Aristotle', 15, 9),
(49, 'Grade 8', 67, 'Aquinas', 15, 9),
(50, 'Grade 9', 71, 'Hobbes', 15, 9),
(51, 'Grade 9', 75, 'Marx', 15, 9),
(52, 'Grade 10', 78, 'Hume', 15, 9),
(53, 'Grade 10', 75, 'Kant', 15, 9),
(54, 'Nursery', 58, 'Sunflower', 15, 8),
(55, 'Nursery', 32, 'Lily', 15, 8),
(56, 'Junior Kinder', 73, 'Rose', 15, 8),
(57, 'Junior Kinder', 33, 'Gumamela', 15, 8),
(58, 'Senior Kinder', 34, 'Sampaguita', 15, 8),
(59, 'Senior Kinder', 35, 'Tulip', 15, 8),
(60, 'Grade 1', 36, 'Blue', 15, 8),
(61, 'Grade 1', 37, 'Red', 15, 8),
(62, 'Grade 2', 74, 'Orange', 15, 8),
(63, 'Grade 2', 75, 'Yellow', 15, 8),
(64, 'Grade 3', 38, 'Pink', 15, 8),
(65, 'Grade 3', 59, 'Green', 15, 8),
(66, 'Grade 4', 32, 'Black', 15, 8),
(67, 'Grade 4', 58, 'Brown', 15, 8),
(68, 'Grade 6', 73, 'Gold', 15, 8),
(69, 'Grade 6', 33, 'Silver', 15, 8),
(70, 'Grade 5', 34, 'Copper', 15, 8),
(71, 'Grade 5', 35, 'Diamond', 15, 8),
(72, 'Grade 7', 45, 'Socrates', 15, 8),
(73, 'Grade 7', 43, 'Plato', 15, 8),
(74, 'Grade 8', 42, 'Aristotle', 15, 8),
(75, 'Grade 8', 46, 'Aquinas', 15, 8),
(76, 'Grade 9', 53, 'Hobbes', 15, 8),
(77, 'Grade 9', 65, 'Marx', 15, 8),
(78, 'Grade 10', 65, 'Hume', 15, 8),
(79, 'Grade 10', 67, 'Kant', 15, 8);

-- --------------------------------------------------------

--
-- Table structure for table `specialization`
--

CREATE TABLE `specialization` (
  `teacher_ID` int(11) NOT NULL,
  `acc_id` varchar(20) NOT NULL,
  `subject_id` int(11) NOT NULL,
  `teaching_type` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `specialization`
--

INSERT INTO `specialization` (`teacher_ID`, `acc_id`, `subject_id`, `teaching_type`) VALUES
(32, 'CST-2018-1328', 0, 'Primary Edu'),
(33, 'CST-2018-1699', 0, 'Primary Edu'),
(34, 'CST-2018-1750', 0, 'Primary Edu'),
(35, 'CST-2018-1937', 0, 'Primary Edu'),
(36, 'CST-2018-2099', 0, 'Primary Edu'),
(37, 'CST-2018-2162', 0, 'Primary Edu'),
(38, 'CST-2018-2647', 0, 'Primary Edu'),
(39, 'CST-2018-488', 0, 'Primary Edu'),
(40, 'CST-2018-4944', 0, 'Primary Edu'),
(41, 'CST-2018-4953', 0, 'Primary Edu'),
(42, 'CST-2018-5666', 13, 'Secondary E'),
(43, 'CST-2018-5543', 13, 'Secondary E'),
(44, 'CST-2018-5714', 14, 'Secondary E'),
(45, 'CST-2018-6448', 14, 'Secondary E'),
(46, 'CST-2018-7161', 15, 'Secondary E'),
(47, 'CST-2018-7352', 16, 'Secondary E'),
(48, 'CST-2018-7629', 15, 'Secondary E'),
(49, 'CST-2018-9638', 16, 'Secondary E'),
(50, 'CST-2018-9666', 17, 'Secondary E'),
(51, 'CST-2018-9941', 17, 'Secondary E'),
(52, 'CST-2020-9910', 18, 'Secondary E'),
(53, 'CST-2018-4071', 18, 'Secondary E'),
(54, 'CST-2018-5484', 19, 'Secondary E'),
(55, 'CST-2018-6150', 19, 'Secondary E'),
(56, 'CST-2018-6661', 20, 'Secondary E'),
(57, 'CST-2018-6819', 20, 'Secondary E'),
(58, 'CST-2018-1059', 0, 'Primary Edu'),
(59, 'CST-2018-2687', 0, 'Primary Edu'),
(60, 'CST-2018-351', 0, 'Primary Edu'),
(61, 'CST-2018-4526', 0, 'Primary Edu'),
(62, 'CST-2018-4822', 0, 'Primary Edu'),
(63, 'CST-2018-6126', 0, 'Primary Edu'),
(64, 'CST-2018-64', 0, 'Primary Edu'),
(65, 'CST-2018-790', 13, 'Secondary E'),
(66, 'CST-2018-8015', 14, 'Secondary E'),
(67, 'CST-2018-8222', 15, 'Secondary E'),
(68, 'CST-2018-8715', 15, 'Secondary E'),
(69, 'CST-2018-888', 16, 'Secondary E'),
(70, 'CST-2018-900', 17, 'Secondary E'),
(71, 'CST-2018-9969', 18, 'Secondary E'),
(72, 'CST-2018-9981', 20, 'Secondary E'),
(73, 'CST-2018-1592', 13, 'Secondary E'),
(74, 'CST-2018-2286', 13, 'Secondary E'),
(75, 'CST-2018-2391', 13, 'Secondary E'),
(76, 'CST-2018-3750', 14, 'Secondary E'),
(77, 'CST-2018-5010', 15, 'Secondary E'),
(78, 'CST-2018-5264', 16, 'Secondary E'),
(79, 'CST-2018-6052', 17, 'Secondary E'),
(80, 'CST-2018-6292', 18, 'Secondary E'),
(81, 'CST-2018-6841', 19, 'Secondary E'),
(82, 'CST-2018-7526', 19, 'Secondary E'),
(83, 'CST-2018-8286', 20, 'Secondary E'),
(84, 'CST-2018-8799', 14, 'Secondary E');

-- --------------------------------------------------------

--
-- Table structure for table `studentenrolledinfo`
--

CREATE TABLE `studentenrolledinfo` (
  `studentenrolled_id` int(11) NOT NULL,
  `sno` varchar(255) NOT NULL,
  `grade_level` varchar(50) NOT NULL,
  `sect_id` int(11) NOT NULL,
  `is_Enrolled` int(11) NOT NULL,
  `sy_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `studentenrolledinfo`
--

INSERT INTO `studentenrolledinfo` (`studentenrolled_id`, `sno`, `grade_level`, `sect_id`, `is_Enrolled`, `sy_id`) VALUES
(1, 'STUD-2019-0001', 'Nursery', 1, 1, 1),
(2, 'STUD-2019-0002', 'Nursery', 1, 1, 1),
(3, 'STUD-2019-0003', 'Nursery', 1, 1, 1),
(4, 'STUD-2019-0005', 'Nursery', 2, 1, 1),
(5, 'STUD-2019-0006', 'Nursery', 1, 1, 1),
(6, 'STUD-2019-0007', 'Nursery', 1, 1, 1),
(7, 'STUD-2019-0008', 'Nursery', 2, 1, 1),
(8, 'STUD-2019-0009', 'Junior Kinder', 3, 1, 1),
(9, 'STUD-2019-0010', 'Junior Kinder', 5, 1, 1),
(10, 'STUD-2019-0013', 'Junior Kinder', 3, 1, 1),
(11, 'STUD-2019-0014', 'Junior Kinder', 5, 1, 1),
(12, 'STUD-2019-0001', 'Nursery', 28, 1, 9),
(13, 'STUD-2019-0002', 'Junior Kinder', 30, 1, 9),
(14, 'STUD-2019-0003', 'Junior Kinder', 30, 1, 9),
(15, 'STUD-2019-0006', 'Junior Kinder', 30, 1, 9),
(16, 'STUD-2019-0007', 'Junior Kinder', 56, 1, 8),
(17, 'STUD-2019-0015', 'Nursery', 2, 1, 1),
(18, 'STUD-2019-0016', 'Nursery', 2, 1, 1),
(19, 'STUD-2019-0005', 'Nursery', 54, 1, 8),
(20, 'STUD-2019-0008', 'Junior Kinder', 56, 1, 8),
(21, 'STUD-2019-0015', 'Junior Kinder', 57, 1, 8),
(22, 'STUD-2019-0016', 'Junior Kinder', 56, 1, 8),
(23, 'STUD-2019-0009', 'Junior Kinder', 30, 1, 9),
(24, 'STUD-2019-0013', 'Senior Kinder', 32, 1, 9),
(25, 'STUD-2019-0017', 'Nursery', 1, 1, 1),
(26, 'STUD-2019-0018', 'Senior Kinder', 6, 1, 1),
(27, 'STUD-2019-0019', 'Senior Kinder', 6, 1, 1),
(28, 'STUD-2019-0020', 'Senior Kinder', 6, 1, 1),
(29, 'STUD-2019-0021', 'Senior Kinder', 6, 1, 1),
(30, 'STUD-2019-0017', 'Nursery', 28, 0, 9),
(31, 'STUD-2019-0021', 'Grade 1', 34, 0, 9),
(32, 'STUD-2019-0018', 'Senior Kinder', 58, 0, 8),
(33, 'STUD-2019-0019', 'Senior Kinder', 58, 0, 8),
(34, 'STUD-2019-0020', 'Grade 1', 60, 0, 8),
(35, 'STUD-2019-0022', 'Grade 8', 48, 1, 1),
(36, 'STUD-2019-0023', 'Grade 7', 20, 1, 1),
(37, 'STUD-2019-0023', 'Grade 8', 48, 1, 9),
(38, 'STUD-2019-0022', 'Grade 8', 48, 1, 9),
(39, 'STUD-2019-0024', 'Grade 7', 20, 0, 1);

-- --------------------------------------------------------

--
-- Table structure for table `students_requirement`
--

CREATE TABLE `students_requirement` (
  `student_req_id` int(11) NOT NULL,
  `student_no` varchar(255) NOT NULL,
  `req_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `students_requirement`
--

INSERT INTO `students_requirement` (`student_req_id`, `student_no`, `req_id`) VALUES
(1, 'STUD-2019-0008', 24),
(2, 'STUD-2019-0008', 30),
(5, 'STUD-2019-0001', 26),
(6, 'STUD-2019-0002', 26),
(7, 'STUD-2019-0003', 26),
(8, 'STUD-2019-0006', 26),
(9, 'STUD-2019-0007', 29),
(10, 'STUD-2019-0015', 24),
(11, 'STUD-2019-0015', 30),
(12, 'STUD-2019-0009', 26),
(13, 'STUD-2019-0013', 26),
(14, 'STUD-2019-0017', 24),
(15, 'STUD-2019-0017', 30),
(16, 'STUD-2019-0018', 24),
(17, 'STUD-2019-0018', 30),
(18, 'STUD-2019-0019', 24),
(19, 'STUD-2019-0019', 30),
(20, 'STUD-2019-0020', 24),
(21, 'STUD-2019-0020', 30),
(22, 'STUD-2019-0021', 24),
(23, 'STUD-2019-0021', 30),
(24, 'STUD-2019-0017', 26),
(25, 'STUD-2019-0021', 26),
(26, 'STUD-2019-0018', 29),
(27, 'STUD-2019-0019', 26),
(28, 'STUD-2019-0023', 26),
(29, 'STUD-2019-0022', 26);

-- --------------------------------------------------------

--
-- Table structure for table `student_balance`
--

CREATE TABLE `student_balance` (
  `balance_id` int(11) NOT NULL,
  `sno` varchar(255) NOT NULL,
  `balance` double NOT NULL,
  `totalPayment` double NOT NULL,
  `modeofpayment` varchar(15) NOT NULL,
  `need_to_pay` double NOT NULL,
  `disc` float NOT NULL,
  `upon_pay` float NOT NULL,
  `SY_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student_balance`
--

INSERT INTO `student_balance` (`balance_id`, `sno`, `balance`, `totalPayment`, `modeofpayment`, `need_to_pay`, `disc`, `upon_pay`, `SY_id`) VALUES
(1, 'STUD-2019-0001', 0, 16186.5, 'Fullpayment', 0, 633.5, 16186.5, 1),
(2, 'STUD-2019-0002', 0, 16820, 'Fullpayment', 0, 0, 16820, 1),
(3, 'STUD-2019-0003', 0, 16820, 'Fullpayment', 0, 0, 16820, 1),
(4, 'STUD-2019-0005', 12503, 5500, 'Monthly', 1389.22, 0, 5500, 1),
(5, 'STUD-2019-0007', 0, 16186.5, 'Fullpayment', 0, 633.5, 16186.5, 1),
(6, 'STUD-2019-0008', 8560, 8560, 'Semi-Annual', 8560, 0, 8560, 1),
(7, 'STUD-2019-0006', 7560, 8560, 'Semi-Annual', 7560, 0, 8560, 1),
(8, 'STUD-2019-0009', 0, 16820, 'Fullpayment', 0, 0, 16820, 1),
(9, 'STUD-2019-0010', 0, 16820, 'Fullpayment', 0, 0, 16820, 1),
(10, 'STUD-2019-0013', 0, 16820, 'Fullpayment', 0, 0, 16820, 1),
(11, 'STUD-2019-0014', 0, 16820, 'Fullpayment', 0, 0, 16820, 1),
(12, 'STUD-2019-0001', 0, 16820, 'Fullpayment', 0, 0, 16820, 9),
(13, 'STUD-2019-0002', 0, 16820, 'Fullpayment', 0, 0, 16820, 9),
(14, 'STUD-2019-0003', 0, 16820, 'Fullpayment', 0, 0, 16820, 9),
(15, 'STUD-2019-0006', 0, 16820, 'Fullpayment', 0, 0, 16820, 9),
(16, 'STUD-2019-0015', 0, 16186.5, 'Fullpayment', 0, 633.5, 16186.5, 1),
(17, 'STUD-2019-0016', 0, 16186.5, 'Fullpayment', 0, 633.5, 16186.5, 1),
(18, 'STUD-2019-0005', 0, 16820, 'Fullpayment', 0, 0, 16820, 8),
(19, 'STUD-2019-0008', 8560, 8560, 'Semi-Annual', 8560, 0, 8560, 8),
(20, 'STUD-2019-0015', 8560, 8560, 'Semi-Annual', 8560, 0, 8560, 8),
(21, 'STUD-2019-0016', 12503, 5500, 'Monthly', 1389.22, 0, 5500, 8),
(22, 'STUD-2019-0007', 0, 16820, 'Fullpayment', 0, 0, 16820, 8),
(23, 'STUD-2019-0009', 0, 16820, 'Fullpayment', 0, 0, 16820, 9),
(24, 'STUD-2019-0013', 0, 16820, 'Fullpayment', 0, 0, 16820, 9),
(25, 'STUD-2019-0017', 13365, 4455, 'Quarterly', 4455, 0, 4455, 1),
(26, 'STUD-2019-0018', 8560, 8560, 'Semi-Annual', 8560, 0, 8560, 1),
(27, 'STUD-2019-0019', 8560, 8560, 'Semi-Annual', 8560, 0, 8560, 1),
(28, 'STUD-2019-0020', 13365, 4455, 'Quarterly', 4455, 0, 4455, 1),
(29, 'STUD-2019-0021', 0, 14919.5, 'Fullpayment', 0, 1900.5, 14919.5, 1),
(30, 'STUD-2019-0022', 0, 22260, 'Fullpayment', 0, 990, 22260, 1),
(31, 'STUD-2019-0023', 0, 23250, 'Fullpayment', 0, 0, 23250, 1),
(32, 'STUD-2019-0023', 0, 25150, 'Fullpayment', 0, 0, 25150, 9),
(33, 'STUD-2019-0022', 0, 25150, 'Fullpayment', 0, 0, 25150, 9);

-- --------------------------------------------------------

--
-- Table structure for table `student_detail`
--

CREATE TABLE `student_detail` (
  `student_id` int(11) NOT NULL,
  `sno` varchar(255) NOT NULL,
  `firstname` varchar(20) NOT NULL,
  `lastname` varchar(20) NOT NULL,
  `middlename` varchar(20) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `age` int(11) NOT NULL,
  `birthdate` varchar(10) NOT NULL,
  `pob` varchar(10) NOT NULL,
  `contact_no` varchar(15) DEFAULT NULL,
  `nationality` varchar(10) NOT NULL,
  `religion` varchar(10) NOT NULL,
  `address` text NOT NULL,
  `studentype` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student_detail`
--

INSERT INTO `student_detail` (`student_id`, `sno`, `firstname`, `lastname`, `middlename`, `gender`, `age`, `birthdate`, `pob`, `contact_no`, `nationality`, `religion`, `address`, `studentype`) VALUES
(1, 'STUD-2019-0001', 'Mary', 'Villar', 'Tadlon', 'Female', 4, '08/10/2015', 'Bacoor', '098372839283', 'Filipino', 'Catholic', 'Imus, Bacoor', 'Old Student'),
(2, 'STUD-2019-0002', 'Ben', 'Ferlina', 'Kidt', 'Male', 4, '08/10/2015', 'Manila', '09872817289', 'Filipino', 'Catholic', 'Panapaan IV, Bacoor', 'Old Student'),
(3, 'STUD-2019-0003', 'Mariel', 'De Jesus', 'Jedier', 'Female', 4, '08/10/2015', 'Mnaila', '09871625181', 'Filipino', 'Catholic', 'Habay I, Bacoor', 'Old Student'),
(4, 'STUD-2019-0004', 'Bea', 'Ferlin', 'Hun', 'Female', 4, '08/10/2015', 'Manila', '09827182761', 'Filipino', 'Catholic', 'Bacoor', 'New Student'),
(5, 'STUD-2019-0005', 'Reniel', 'Denver', 'Loer', 'Male', 4, '08/11/2015', 'Cebu', '0918172976', 'Filipino', 'catholic', 'Panapaan IV, bacoor', 'Returnee Student'),
(6, 'STUD-2019-0006', 'Jay', 'Holly', 'Koll', 'Male', 4, '08/11/2015', 'manila', '09817281902', 'Filipino', 'Catholic', 'habay I , Bacoor', 'Old Student'),
(7, 'STUD-2019-0007', 'Gracia', 'Guada', 'Yen', 'Female', 4, '08/12/2015', 'Cavite', '0981729817', 'Filipino', 'Catholic', 'Mambog, Bacoor', 'Returnee Student'),
(8, 'STUD-2019-0008', 'Hatry', 'Harley', 'Mandy4', 'Male', 4, '08/12/2015', 'Manila', '09172819281', 'Filipino', 'Catholic', 'Habay II, Bacoor', 'Returnee Student'),
(9, 'STUD-2019-0009', 'Herith', 'Lohue', 'Bavor', 'Male', 5, '08/12/2014', 'Manila', '09871287651', 'Filipino', 'Catholic', 'Mambog I, Bacoor', 'Old Student'),
(10, 'STUD-2019-0010', 'Gerd', 'Villanueva', 'Juns', 'Male', 5, '08/12/2015', 'Noveleta, ', '09456789124', 'Filipino', 'Catholic', 'Kawit Bacoor', 'New Student'),
(13, 'STUD-2019-0013', 'Jean', 'Ortiz', '', 'Male', 5, '08/12/2015', 'Cavite', '', 'Filipino', 'Catholic', 'Bacoor City, Cavite', 'Old Student'),
(14, 'STUD-2019-0014', 'Carl', 'Dela Cruz', 'Cruz', 'Male', 5, '08/12/2015', 'Cavite', '', 'Filipino', 'Catholic', 'Bacoor City, Cavite', 'New Student'),
(15, 'STUD-2019-0015', 'Freshca', 'Ferdin', 'Berdin', 'Female', 4, '08/12/2014', 'Manila', '098271629178', 'Filipino', 'Catholic', 'Panapaan Iv, bacoor', 'Returnee Student'),
(16, 'STUD-2019-0016', 'Gerdin', 'Villa', 'Nuer', 'Female', 4, '08/12/2014', 'Manila', '097126371829', 'Filipino', 'catholic', 'Bacoor', 'Returnee Student'),
(17, 'STUD-2019-0017', 'Jerry', 'Palompon', 'C', 'Male', 5, '08/21/2015', 'Bacoor', '4506460', 'Filipino', 'Catholic', '55 Francisco St. Mabolo 3 Bacoor Cavite', 'Old Student'),
(18, 'STUD-2019-0018', 'Jimuel', 'Aareso', 'B', 'Male', 5, '08/21/2015', 'Bacoor', '0934673873', 'Filipino', 'Catholic', 'Bacoor Cavite', 'Returnee Student'),
(19, 'STUD-2019-0019', 'Lee Ann', 'Florez', 'B', 'Female', 5, '08/21/2015', 'Bacoor', '', 'Filipino', 'Catholic', 'Bacoor Cavite', 'Old Student'),
(20, 'STUD-2019-0020', 'Alyssa', 'Adolfo', 'G', 'Male', 5, '08/21/2015', 'Bacoor', '', 'Filipino', 'Catholic', 'Bacoor Cavite', 'Returnee Student'),
(21, 'STUD-2019-0021', 'Julie', 'Asis', 'C', 'Female', 5, '08/21/2015', 'Bacoor', '', 'Filipino', 'Catholic', 'Bacoor Cavite', 'Old Student'),
(22, 'STUD-2019-0022', 'Felisha', 'Fernando', 'Juander', 'Female', 12, '08/28/2005', 'Mindanao', '091827319120', 'Filipino', 'Catholic', 'Imus,Bacoor', 'Old Student'),
(23, 'STUD-2019-0023', 'Mark', 'Felsi', 'Nesh', 'Male', 12, '08/28/2005', 'Manila', '09827383920', 'Filipino', 'Catholic', 'Imus, Bacoor', 'Old Student'),
(24, 'STUD-2019-0024', 'Feh', 'Felisha', 'Guand', 'Female', 12, '08/28/2005', 'Manila', '01928764829', 'Filipino', 'Catholic', 'Imus, Bacoor', 'New Student');

-- --------------------------------------------------------

--
-- Table structure for table `student_family_details`
--

CREATE TABLE `student_family_details` (
  `student_fam_id` int(11) NOT NULL,
  `sno` varchar(255) NOT NULL,
  `father_name` varchar(30) DEFAULT NULL,
  `father_no` varchar(10) DEFAULT NULL,
  `father_occu` varchar(10) DEFAULT NULL,
  `father_comp_name` varchar(15) DEFAULT 'NULL',
  `father_Ctel_no` varchar(15) DEFAULT 'NULL',
  `father_office_address` text,
  `mother_name` varchar(30) DEFAULT 'NULL',
  `mother_no` varchar(10) DEFAULT 'NULL',
  `mother_occu` varchar(10) DEFAULT 'NULL',
  `mother_comp_name` text NOT NULL,
  `mother_Ctel_no` varchar(15) DEFAULT NULL,
  `mother_office_add` text,
  `guardian_name` varchar(30) DEFAULT NULL,
  `guardian_add` text,
  `guardian_relation` varchar(10) DEFAULT NULL,
  `guardian_no` varchar(15) DEFAULT NULL,
  `parent_status` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student_family_details`
--

INSERT INTO `student_family_details` (`student_fam_id`, `sno`, `father_name`, `father_no`, `father_occu`, `father_comp_name`, `father_Ctel_no`, `father_office_address`, `mother_name`, `mother_no`, `mother_occu`, `mother_comp_name`, `mother_Ctel_no`, `mother_office_add`, `guardian_name`, `guardian_add`, `guardian_relation`, `guardian_no`, `parent_status`) VALUES
(1, 'STUD-2019-0001', 'Daniel Villar', '0982910287', 'OFW', 'manila coorpera', '', 'Manila', 'Frace Villar', '0982918201', 'N/A', 'N/A', '', 'N/A', '', '', '', '', 'Living Together'),
(2, 'STUD-2019-0002', 'Dennis Ferlina', '0987382372', 'N/A', 'N/A', '', 'N/A', 'Grace Ferlina', '0982910297', 'N/A', 'N/A', '', 'N/A', '', '', '', '', 'Living Together'),
(3, 'STUD-2019-0003', 'Justin De Jesus', '0981728109', 'N/A', 'N/A', '', 'N/A', 'Dyese De Jesus', '0982718271', 'N/A', 'N/A', '', 'N/A', '', '', '', '', 'Living Together'),
(4, 'STUD-2019-0004', 'Vendet Ferlin', '0987192872', 'N/A', 'N/A', '', 'N/A', 'Grace Ferlin', '0987281987', 'N/A', 'N/A', '', 'N/A', '', '', '', '', 'Living Together'),
(5, 'STUD-2019-0005', 'Rokie Denver', '0982918271', 'N/A', 'N/A', '', 'N/A', 'Erlin Denver', '0981728198', 'N/A', 'N/A', '', 'N/A', '', '', '', '', 'Living Together'),
(6, 'STUD-2019-0006', 'Kurt Holly', '0981728192', 'N/A', 'N/A', '', 'N/A', 'Francine Holly', '0981728198', 'N/A', 'N/A', '', 'N/A', '', '', '', '', 'Living Together'),
(7, 'STUD-2019-0007', 'Ken Guada', '0917261819', 'N/A', 'N/A', '', 'N/A', 'Frasher', '0917261829', 'N/A', 'N/A', '', 'N/A', '', '', '', '', 'Living Together'),
(8, 'STUD-2019-0008', 'Gerlic Harley', '0982718276', 'N/A', 'N/A', '', 'N/A', 'Daniela Harley', '0917281765', 'N/A', 'N/A', '', 'N/A', '', '', '', '', 'Living Together'),
(9, 'STUD-2019-0009', 'Jay Lohue', '0981726542', 'N/A', 'N/A', '', 'N/A', 'Grace Lohue', '0918273645', 'N/A', 'N/A', '', 'N/A', '', '', '', '', 'Living Together'),
(10, 'STUD-2019-0010', 'Kent Villanueva', '0956784321', 'N/A', 'N/A', '', 'N/A', 'Freya Villanueva', '0956732145', 'N/A', 'N/A', '', 'N/A', '', '', '', '', 'Living Together'),
(13, 'STUD-2019-0013', 'Marty Ortiz', '0987658768', 'Driver', '', '', '', 'Tina Dela Cruz', '0978757876', 'N/A', '', '', '', '', '', '', '', 'Living Together'),
(14, 'STUD-2019-0014', 'Tony Dela Cruz', '0987126787', 'Driver', '', '', '', 'Angel Cruz', '0978767676', 'N/A', '', '', '', '', '', '', '', 'Living Together'),
(15, 'STUD-2019-0015', 'Gerlad Ferdin', '0917281615', 'N/A', 'N/A', '', 'N/A', 'Desire Ferdin', '0913241526', 'N/A', 'N/A', '', 'N/A', '', '', '', '', 'Living Together'),
(16, 'STUD-2019-0016', 'Christian Villa', '0928198273', 'N/A', 'N/A', '', 'N/A', 'Christine Villa', '0917286351', 'N/A', 'N/A', '', 'N/A', '', '', '', '', 'Living Together'),
(17, 'STUD-2019-0017', 'Je Palompon', '0936457875', 'N/A', '', '', '', 'Nena  Palompon', '0936457567', 'N/A', '', '', '', '', '', '', '', 'Living Together'),
(18, 'STUD-2019-0018', 'Je Aareso', '0935467873', 'N/A', '', '', '', 'Crizza Aareso', '0936748478', 'N/A', '', '', '', '', '', '', '', 'Living Together'),
(19, 'STUD-2019-0019', 'Jez Florez', '0935647773', 'N/A', '', '', '', 'Je Florez', '0935678765', 'N/A', '', '', '', '', '', '', '', 'Living Together'),
(20, 'STUD-2019-0020', 'Jude Adolfo', '0936546765', 'N/A', '', '', '', 'Jez Adolfo', '0936478382', 'N/A', '', '', '', '', '', '', '', 'Living Together'),
(21, 'STUD-2019-0021', 'Jul Asis', '0935645787', 'N/A', '', '', '', 'Je Asis', '0943567687', 'N/A', '', '', '', '', '', '', '', 'Living Together'),
(22, 'STUD-2019-0022', 'Kent Fernando', '0918273829', 'N/A', 'N/A', '', 'N/A', 'Grace Fernando', '0918273820', 'N/A', 'N/A', '', 'N/A', '', '', '', '', 'Living Together'),
(23, 'STUD-2019-0023', 'Ferb Felsi', '0987678924', 'N/A', 'N/A', '', 'N/A', 'Grace Felsi', '0918271829', 'N/A', 'N/A', '', 'N/A', '', '', '', '', 'Living Together'),
(24, 'STUD-2019-0024', 'Gel Felisha', '0978192837', 'N/A', 'N/A', '', 'N/A', 'Helen Felisha', '0982718271', 'N/A', 'N/A', '', 'N/A', '', '', '', '', 'Living Together');

-- --------------------------------------------------------

--
-- Table structure for table `student_grades`
--

CREATE TABLE `student_grades` (
  `studentgrade_id` int(11) NOT NULL,
  `sno` varchar(255) NOT NULL,
  `grade_first` double NOT NULL,
  `grade_second` double NOT NULL,
  `grade_third` double NOT NULL,
  `grade_fourth` decimal(10,0) NOT NULL,
  `avg` double NOT NULL,
  `subject_id` int(11) NOT NULL,
  `sect_id` int(11) NOT NULL,
  `teacher_ID` int(11) NOT NULL,
  `SY_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student_grades`
--

INSERT INTO `student_grades` (`studentgrade_id`, `sno`, `grade_first`, `grade_second`, `grade_third`, `grade_fourth`, `avg`, `subject_id`, `sect_id`, `teacher_ID`, `SY_ID`) VALUES
(1, 'STUD-2019-0001', 85, 85, 80, '85', 83.75, 66, 1, 58, 1),
(2, 'STUD-2019-0002', 81, 80, 81, '81', 80.75, 66, 1, 58, 1),
(3, 'STUD-2019-0003', 85, 85, 85, '85', 85, 66, 1, 58, 1),
(4, 'STUD-2019-0006', 75, 85, 85, '95', 85, 66, 1, 58, 1),
(5, 'STUD-2019-0007', 75, 68, 85, '85', 78.25, 66, 1, 58, 1),
(6, 'STUD-2019-0001', 75, 68, 85, '85', 78.25, 67, 1, 58, 1),
(7, 'STUD-2019-0002', 75, 75, 75, '85', 77.5, 67, 1, 58, 1),
(8, 'STUD-2019-0003', 85, 95, 95, '95', 92.5, 67, 1, 58, 1),
(9, 'STUD-2019-0006', 85, 85, 80, '95', 86.25, 67, 1, 58, 1),
(10, 'STUD-2019-0007', 96, 95, 95, '95', 95.25, 67, 1, 58, 1),
(11, 'STUD-2019-0001', 70, 75, 75, '67', 71.75, 68, 1, 58, 1),
(12, 'STUD-2019-0002', 75, 65, 75, '70', 71.25, 68, 1, 58, 1),
(13, 'STUD-2019-0003', 67, 70, 70, '65', 68, 68, 1, 58, 1),
(14, 'STUD-2019-0006', 88, 65, 95, '95', 85.75, 68, 1, 58, 1),
(15, 'STUD-2019-0007', 75, 85, 85, '95', 85, 68, 1, 58, 1),
(16, 'STUD-2019-0001', 65, 65, 75, '75', 70, 69, 1, 58, 1),
(17, 'STUD-2019-0002', 75, 65, 65, '65', 67.5, 69, 1, 58, 1),
(18, 'STUD-2019-0003', 85, 85, 85, '85', 85, 69, 1, 58, 1),
(19, 'STUD-2019-0006', 85, 90, 95, '95', 91.25, 69, 1, 58, 1),
(20, 'STUD-2019-0007', 68, 95, 95, '95', 88.25, 69, 1, 58, 1),
(21, 'STUD-2019-0001', 65, 65, 85, '65', 70, 70, 1, 58, 1),
(22, 'STUD-2019-0002', 85, 85, 95, '95', 90, 70, 1, 58, 1),
(23, 'STUD-2019-0003', 75, 75, 75, '88', 78.25, 70, 1, 58, 1),
(24, 'STUD-2019-0006', 85, 85, 85, '95', 87.5, 70, 1, 58, 1),
(25, 'STUD-2019-0007', 85, 85, 95, '95', 90, 70, 1, 58, 1),
(26, 'STUD-2019-0005', 85, 88, 95, '95', 90.75, 66, 2, 32, 1),
(27, 'STUD-2019-0008', 85, 85, 95, '95', 90, 66, 2, 32, 1),
(28, 'STUD-2019-0015', 85, 68, 85, '95', 83.25, 66, 2, 32, 1),
(29, 'STUD-2019-0016', 85, 85, 85, '85', 85, 66, 2, 32, 1),
(30, 'STUD-2019-0005', 75, 75, 85, '95', 82.5, 67, 2, 32, 1),
(31, 'STUD-2019-0008', 75, 85, 95, '95', 87.5, 67, 2, 32, 1),
(32, 'STUD-2019-0015', 85, 85, 85, '95', 87.5, 67, 2, 32, 1),
(33, 'STUD-2019-0016', 80, 85, 85, '90', 85, 67, 2, 32, 1),
(34, 'STUD-2019-0005', 75, 65, 65, '75', 70, 68, 2, 32, 1),
(35, 'STUD-2019-0008', 70, 75, 70, '70', 71.25, 68, 2, 32, 1),
(36, 'STUD-2019-0015', 74, 74, 74, '75', 74.25, 68, 2, 32, 1),
(37, 'STUD-2019-0016', 88, 95, 95, '95', 93.25, 68, 2, 32, 1),
(38, 'STUD-2019-0005', 74, 76, 75, '65', 72.5, 69, 2, 32, 1),
(39, 'STUD-2019-0008', 75, 75, 65, '70', 71.25, 69, 2, 32, 1),
(40, 'STUD-2019-0015', 65, 85, 85, '85', 80, 69, 2, 32, 1),
(41, 'STUD-2019-0016', 88, 95, 95, '96', 93.5, 69, 2, 32, 1),
(42, 'STUD-2019-0005', 65, 75, 65, '80', 71.25, 70, 2, 32, 1),
(43, 'STUD-2019-0008', 85, 85, 88, '95', 88.25, 70, 2, 32, 1),
(44, 'STUD-2019-0015', 65, 85, 95, '95', 85, 70, 2, 32, 1),
(45, 'STUD-2019-0016', 85, 85, 85, '85', 85, 70, 2, 32, 1),
(46, 'STUD-2019-0009', 70, 70, 70, '70', 70, 117, 3, 73, 1),
(47, 'STUD-2019-0013', 80, 80, 80, '80', 80, 117, 3, 73, 1),
(48, 'STUD-2019-0013', 80, 80, 80, '80', 80, 116, 3, 73, 1),
(49, 'STUD-2019-0009', 70, 70, 70, '70', 70, 116, 3, 73, 1),
(50, 'STUD-2019-0009', 70, 70, 70, '70', 70, 118, 3, 73, 1),
(51, 'STUD-2019-0013', 80, 80, 80, '80', 80, 118, 3, 73, 1),
(52, 'STUD-2019-0009', 80, 80, 80, '80', 80, 119, 3, 73, 1),
(53, 'STUD-2019-0013', 80, 80, 80, '80', 80, 119, 3, 73, 1),
(54, 'STUD-2019-0009', 80, 80, 80, '80', 80, 120, 3, 73, 1),
(55, 'STUD-2019-0013', 80, 80, 80, '80', 80, 120, 3, 73, 1),
(56, 'STUD-2019-0017', 65, 65, 65, '75', 67.5, 66, 1, 58, 1),
(57, 'STUD-2019-0017', 65, 85, 65, '65', 70, 67, 1, 58, 1),
(58, 'STUD-2019-0017', 75, 65, 85, '65', 72.5, 68, 1, 58, 1),
(59, 'STUD-2019-0017', 75, 85, 65, '65', 72.5, 69, 1, 58, 1),
(60, 'STUD-2019-0017', 65, 65, 95, '65', 72.5, 70, 1, 58, 1),
(61, 'STUD-2019-0018', 65, 85, 65, '65', 70, 121, 6, 34, 1),
(62, 'STUD-2019-0019', 65, 98, 65, '65', 73.25, 121, 6, 34, 1),
(63, 'STUD-2019-0020', 95, 95, 95, '95', 95, 121, 6, 34, 1),
(64, 'STUD-2019-0021', 75, 85, 95, '90', 86.25, 121, 6, 34, 1),
(65, 'STUD-2019-0018', 65, 65, 75, '85', 72.5, 122, 6, 34, 1),
(66, 'STUD-2019-0019', 75, 75, 65, '65', 70, 122, 6, 34, 1),
(67, 'STUD-2019-0020', 85, 88, 89, '90', 88, 122, 6, 34, 1),
(68, 'STUD-2019-0021', 75, 85, 85, '95', 85, 122, 6, 34, 1),
(69, 'STUD-2019-0018', 85, 65, 65, '65', 70, 123, 6, 34, 1),
(70, 'STUD-2019-0019', 95, 65, 65, '65', 72.5, 123, 6, 34, 1),
(71, 'STUD-2019-0020', 75, 85, 85, '95', 85, 123, 6, 34, 1),
(72, 'STUD-2019-0021', 79, 85, 89, '90', 85.75, 123, 6, 34, 1),
(73, 'STUD-2019-0018', 65, 65, 95, '65', 72.5, 124, 6, 34, 1),
(74, 'STUD-2019-0019', 65, 95, 65, '65', 72.5, 124, 6, 34, 1),
(75, 'STUD-2019-0020', 85, 85, 95, '95', 90, 124, 6, 34, 1),
(76, 'STUD-2019-0021', 90, 95, 98, '99', 95.5, 124, 6, 34, 1),
(77, 'STUD-2019-0018', 78, 65, 65, '65', 68.25, 125, 6, 34, 1),
(78, 'STUD-2019-0019', 75, 85, 88, '95', 85.75, 125, 6, 34, 1),
(79, 'STUD-2019-0020', 75, 89, 90, '97', 87.75, 125, 6, 34, 1),
(80, 'STUD-2019-0021', 89, 89, 95, '98', 92.75, 125, 6, 34, 1),
(81, 'STUD-2019-0022', 85, 85, 94, '95', 89.75, 101, 20, 52, 1),
(82, 'STUD-2019-0023', 85, 85, 95, '85', 87.5, 101, 20, 52, 1),
(83, 'STUD-2019-0022', 87, 95, 95, '95', 93, 102, 20, 47, 1),
(84, 'STUD-2019-0023', 85, 85, 95, '85', 87.5, 102, 20, 47, 1),
(85, 'STUD-2019-0022', 65, 75, 65, '65', 67.5, 103, 20, 44, 1),
(86, 'STUD-2019-0023', 75, 85, 95, '85', 85, 103, 20, 44, 1),
(87, 'STUD-2019-0022', 75, 75, 85, '85', 80, 104, 20, 42, 1),
(88, 'STUD-2019-0023', 75, 85, 85, '90', 83.75, 104, 20, 42, 1),
(89, 'STUD-2019-0022', 75, 65, 65, '65', 67.5, 105, 20, 50, 1),
(90, 'STUD-2019-0023', 85, 87, 89, '90', 87.75, 105, 20, 50, 1),
(91, 'STUD-2019-0022', 85, 85, 95, '95', 90, 106, 20, 46, 1),
(92, 'STUD-2019-0023', 85, 85, 95, '95', 90, 106, 20, 46, 1),
(93, 'STUD-2019-0022', 75, 85, 95, '95', 87.5, 107, 20, 54, 1),
(94, 'STUD-2019-0023', 85, 95, 95, '95', 92.5, 107, 20, 54, 1),
(95, 'STUD-2019-0022', 85, 95, 97, '98', 93.75, 108, 20, 56, 1),
(96, 'STUD-2019-0023', 85, 88, 90, '95', 89.5, 108, 20, 56, 1);

-- --------------------------------------------------------

--
-- Table structure for table `student_reservepay`
--

CREATE TABLE `student_reservepay` (
  `reservepay` int(11) NOT NULL,
  `sno` varchar(255) NOT NULL,
  `payment` float NOT NULL,
  `syid` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student_reservepay`
--

INSERT INTO `student_reservepay` (`reservepay`, `sno`, `payment`, `syid`) VALUES
(1, 'STUD-2019-0006', 1000, 1),
(2, 'STUD-2019-0010', 1000, 1);

-- --------------------------------------------------------

--
-- Table structure for table `stud_history_details`
--

CREATE TABLE `stud_history_details` (
  `stud_his_id` int(11) NOT NULL,
  `sno` varchar(255) NOT NULL,
  `nameschool` text NOT NULL,
  `past_school_add` text NOT NULL,
  `past_level` varchar(20) NOT NULL,
  `year_attended` varchar(10) NOT NULL,
  `isCompletedVacine` varchar(11) NOT NULL,
  `vacination_details` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `stud_history_details`
--

INSERT INTO `stud_history_details` (`stud_his_id`, `sno`, `nameschool`, `past_school_add`, `past_level`, `year_attended`, `isCompletedVacine`, `vacination_details`) VALUES
(1, 'STUD-2019-0001', 'N/A', 'N/A', 'N/a', '08/10/2000', 'No', ''),
(2, 'STUD-2019-0002', 'N/A', 'N/A', 'N/a', '08/10/2020', 'No', ''),
(3, 'STUD-2019-0003', 'N/A', 'N/A', 'N/a', '08/10/2020', 'No', ''),
(4, 'STUD-2019-0004', 'N/A', 'N/A', 'N/a', '08/10/2020', 'No', ''),
(5, 'STUD-2019-0005', 'N/A', 'N/A', 'N/a', '08/11/2020', 'No', ''),
(6, 'STUD-2019-0006', 'N/A', 'N/A', 'N/a', '08/11/2020', 'No', ''),
(7, 'STUD-2019-0007', 'N/A', 'N/A', 'N/a', '08/12/2020', 'No', ''),
(8, 'STUD-2019-0008', 'N/A', 'N/A', 'N/a', '08/12/2020', 'No', ''),
(9, 'STUD-2019-0009', 'Bacoor Elem School', 'Bacoor', 'N/a', '08/12/2020', 'No', ''),
(10, 'STUD-2019-0010', 'Mandaluyong Elem school', 'Mandaluyong City', 'Nursery', '08/12/2019', 'Yes', 'Polio, Measles'),
(13, 'STUD-2019-0013', 'Pre Love Preschool', 'Bacoor', 'Nursery', '08/12/2020', 'No', ''),
(14, 'STUD-2019-0014', 'Pre Love Preschool', 'Bacoor', 'Nursery', '08/12/2020', 'No', ''),
(15, 'STUD-2019-0015', 'N/A', 'N/A', 'N/a', '08/12/2020', 'No', ''),
(16, 'STUD-2019-0016', 'N/A', 'N/A', 'N/a', '08/12/2020', 'No', ''),
(17, 'STUD-2019-0017', 'St.Peregreen Institute', 'Bacoor', 'N/a', '08/21/2020', 'No', ''),
(18, 'STUD-2019-0018', 'St Peregreen Institute', '', 'N/a', '08/21/2020', 'No', ''),
(19, 'STUD-2019-0019', 'St.Peregreen', '', 'Senior Kinder', '08/21/2020', 'No', ''),
(20, 'STUD-2019-0020', 'St Peregreen', 'Bacoor', 'Nursery', '08/21/2020', 'No', ''),
(21, 'STUD-2019-0021', 'St Peregreen', 'Bacoor', 'Junior Kinder', '08/21/2020', 'No', ''),
(22, 'STUD-2019-0022', 'Bacoor', 'Bacoor', 'Grade 6', '08/28/2020', 'No', ''),
(23, 'STUD-2019-0023', 'Mandaluyong Elem School', 'Mandaluyong', 'Grade 6', '08/28/2020', 'No', ''),
(24, 'STUD-2019-0024', 'Bacoor Elem School', 'Bacoor', 'Grade 6', '08/28/2020', 'Yes', '');

-- --------------------------------------------------------

--
-- Table structure for table `subjects`
--

CREATE TABLE `subjects` (
  `subject_id` int(11) NOT NULL,
  `grade_level` text NOT NULL,
  `subject_name` text NOT NULL,
  `subject_type_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `subjects`
--

INSERT INTO `subjects` (`subject_id`, `grade_level`, `subject_name`, `subject_type_id`) VALUES
(66, 'Nursery', 'Mastery of the Alphabet Sounds & Letter', 13),
(67, 'Nursery', 'Days of the Week This is & That is (Reading)', 13),
(68, 'Nursery', 'Transportation', 15),
(69, 'Nursery', 'Christian Living', 16),
(70, 'Nursery', 'Counting numbers 1-10', 14),
(71, 'Grade 1', 'Christian Living', 16),
(72, 'Grade 1', 'Mathematics', 14),
(73, 'Grade 1', 'English', 13),
(74, 'Grade 1', 'Computer', 19),
(75, 'Grade 1', 'Filipino', 17),
(76, 'Grade 1', 'Araling Panlipunan', 18),
(77, 'Grade 2', 'Christian Living', 16),
(78, 'Grade 2', 'English', 13),
(79, 'Grade 2', 'Mathematics', 14),
(80, 'Grade 2', 'Filipino', 17),
(81, 'Grade 2', 'Science', 15),
(82, 'Grade 2', 'Computer', 19),
(83, 'Grade 3', 'MAPEH', 20),
(84, 'Grade 3', 'English', 13),
(85, 'Grade 3', 'Mathematics', 14),
(86, 'Grade 3', 'Christian Living', 16),
(87, 'Grade 3', 'Computer', 19),
(88, 'Grade 3', 'Filipino', 17),
(89, 'Grade 4', 'English', 13),
(90, 'Grade 4', 'Mathematics', 14),
(91, 'Grade 4', 'Science', 15),
(92, 'Grade 4', 'Computer', 19),
(93, 'Grade 4', 'MAPEH', 20),
(94, 'Grade 4', 'Araling Panlipunan', 18),
(95, 'Grade 4', 'HELE', 19),
(96, 'Grade 5', 'Math', 14),
(97, 'Grade 5', 'Filipino', 17),
(98, 'Grade 5', 'Araling Panlipunan', 18),
(99, 'Grade 5', 'Computer', 19),
(100, 'Grade 5', 'English', 13),
(101, 'Grade 7', 'Araling Panlipunan', 18),
(102, 'Grade 7', 'Christian Living', 16),
(103, 'Grade 7', 'Mathematics', 14),
(104, 'Grade 7', 'English', 13),
(105, 'Grade 7', 'Filipino', 17),
(106, 'Grade 7', 'Science', 15),
(107, 'Grade 7', 'Computer', 19),
(108, 'Grade 7', 'MAPEH', 20),
(109, 'Grade 8', 'Christian Living', 16),
(110, 'Grade 8', 'Linear Function', 14),
(111, 'Grade 8', 'English', 13),
(112, 'Grade 8', 'Filipino', 17),
(113, 'Grade 8', 'Science', 15),
(114, 'Grade 8', 'Computer', 19),
(115, 'Grade 8', 'Araling Panlipunan', 18),
(116, 'Junior Kinder', 'Mastery (Reading)', 13),
(117, 'Junior Kinder', 'Syllables', 13),
(118, 'Junior Kinder', 'Science', 15),
(119, 'Junior Kinder', 'Christian Living', 16),
(120, 'Junior Kinder', 'Filipino', 17),
(121, 'Senior Kinder', 'Mastery  (Reading)', 13),
(122, 'Senior Kinder', 'Syllables', 13),
(123, 'Senior Kinder', 'Science', 15),
(124, 'Senior Kinder', 'Filipino', 17),
(125, 'Senior Kinder', 'Mathematics', 14),
(126, 'Grade 6', 'English', 13),
(127, 'Grade 6', 'Mathematics', 14),
(128, 'Grade 6', 'Science', 15),
(129, 'Grade 6', 'Christian Living', 16),
(130, 'Grade 6', 'Filipino', 17),
(131, 'Grade 6', 'Computer', 19),
(132, 'Grade 6', 'MAPEH', 20),
(133, 'Grade 9', 'English', 13),
(134, 'Grade 9', 'Math', 14),
(135, 'Grade 9', 'Science', 15),
(136, 'Grade 9', 'Values', 16),
(137, 'Grade 9', 'Filipino', 17),
(138, 'Grade 10', 'English', 13),
(139, 'Grade 10', 'Math', 14),
(140, 'Grade 10', 'Science', 15),
(141, 'Grade 10', 'Values', 16),
(142, 'Grade 10', 'History', 18);

-- --------------------------------------------------------

--
-- Table structure for table `subjectype`
--

CREATE TABLE `subjectype` (
  `sub_type_id` int(11) NOT NULL,
  `subject_type` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `subjectype`
--

INSERT INTO `subjectype` (`sub_type_id`, `subject_type`) VALUES
(13, 'English'),
(14, 'Mathematics'),
(15, 'Science'),
(16, 'Values'),
(17, 'Filipino'),
(18, 'History'),
(19, 'TLE'),
(20, 'MAPEH');

-- --------------------------------------------------------

--
-- Table structure for table `timestamp`
--

CREATE TABLE `timestamp` (
  `timestamp_id` int(11) NOT NULL,
  `start_time` time NOT NULL,
  `end_time` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `timestamp`
--

INSERT INTO `timestamp` (`timestamp_id`, `start_time`, `end_time`) VALUES
(1, '07:00:00', '07:40:00'),
(2, '07:40:00', '08:20:00'),
(3, '08:20:00', '09:00:00'),
(4, '09:00:00', '09:30:00'),
(5, '09:30:00', '10:10:00'),
(6, '10:10:00', '11:00:00'),
(7, '11:00:00', '11:40:00'),
(8, '11:40:00', '12:20:00'),
(9, '12:20:00', '13:00:00'),
(10, '13:00:00', '13:40:00'),
(11, '13:40:00', '14:20:00'),
(12, '14:20:00', '15:00:00'),
(14, '17:00:00', '17:40:00'),
(15, '15:00:00', '15:40:00'),
(16, '15:40:00', '16:10:00'),
(17, '16:10:00', '17:20:00'),
(18, '17:20:00', '18:00:00'),
(19, '18:00:00', '18:30:00');

-- --------------------------------------------------------

--
-- Table structure for table `tuition_fee`
--

CREATE TABLE `tuition_fee` (
  `tf_id` int(11) NOT NULL,
  `grade_level` text NOT NULL,
  `tuition_fee` double NOT NULL,
  `mode_of_payment` text NOT NULL,
  `SY_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tuition_fee`
--

INSERT INTO `tuition_fee` (`tf_id`, `grade_level`, `tuition_fee`, `mode_of_payment`, `SY_ID`) VALUES
(73, 'Nursery', 12670, 'Fullpayment', 1),
(74, 'Nursery', 12970, 'Semi-Annual', 1),
(75, 'Nursery', 13670, 'Quarterly', 1),
(76, 'Nursery', 13853, 'Monthly', 1),
(77, 'Junior Kinder', 12670, 'Fullpayment', 1),
(78, 'Junior Kinder', 12970, 'Semi-Annual', 1),
(79, 'Junior Kinder', 13670, 'Quarterly', 1),
(80, 'Junior Kinder', 13853, 'Monthly', 1),
(81, 'Senior Kinder', 12670, 'Fullpayment', 1),
(82, 'Senior Kinder', 12970, 'Semi-Annual', 1),
(83, 'Senior Kinder', 13670, 'Quarterly', 1),
(84, 'Senior Kinder', 13853, 'Monthly', 1),
(85, 'Grade 1', 14757, 'Fullpayment', 1),
(86, 'Grade 1', 15057, 'Semi-Annual', 1),
(87, 'Grade 1', 15755, 'Quarterly', 1),
(88, 'Grade 1', 16102, 'Monthly', 1),
(89, 'Grade 2', 15057, 'Semi-Annual', 1),
(90, 'Grade 2', 15755, 'Quarterly', 1),
(91, 'Grade 2', 14757, 'Fullpayment', 1),
(92, 'Grade 2', 16102, 'Monthly', 1),
(93, 'Grade 3', 14757, 'Fullpayment', 1),
(94, 'Grade 3', 15057, 'Semi-Annual', 1),
(95, 'Grade 3', 15755, 'Quarterly', 1),
(96, 'Grade 3', 16102, 'Monthly', 1),
(97, 'Grade 4', 15029, 'Fullpayment', 1),
(98, 'Grade 4', 15329, 'Semi-Annual', 1),
(99, 'Grade 4', 16029, 'Quarterly', 1),
(100, 'Grade 4', 16419, 'Monthly', 1),
(101, 'Grade 5', 15029, 'Fullpayment', 1),
(102, 'Grade 5', 15329, 'Semi-Annual', 1),
(103, 'Grade 5', 16029, 'Quarterly', 1),
(104, 'Grade 5', 16419, 'Monthly', 1),
(105, 'Grade 6', 15029, 'Fullpayment', 1),
(106, 'Grade 6', 15329, 'Semi-Annual', 1),
(107, 'Grade 6', 16029, 'Quarterly', 1),
(108, 'Grade 6', 16419, 'Monthly', 1),
(109, 'Grade 7', 19800, 'Fullpayment', 1),
(110, 'Grade 7', 20100, 'Semi-Annual', 1),
(111, 'Grade 7', 20520, 'Quarterly', 1),
(112, 'Grade 7', 21500, 'Monthly', 1),
(113, 'Grade 8', 21000, 'Fullpayment', 1),
(114, 'Grade 8', 21350, 'Semi-Annual', 1),
(115, 'Grade 8', 21750, 'Quarterly', 1),
(116, 'Grade 8', 22050, 'Monthly', 1),
(117, 'Grade 9', 22100, 'Fullpayment', 1),
(118, 'Grade 9', 22400, 'Semi-Annual', 1),
(119, 'Grade 9', 22920, 'Quarterly', 1),
(120, 'Grade 9', 23420, 'Monthly', 1),
(121, 'Grade 10', 23200, 'Fullpayment', 1),
(122, 'Grade 10', 23420, 'Semi-Annual', 1),
(123, 'Grade 10', 23850, 'Quarterly', 1),
(124, 'Grade 10', 24150, 'Monthly', 1),
(125, 'Nursery', 12670, 'Fullpayment', 9),
(126, 'Nursery', 12970, 'Semi-Annual', 9),
(127, 'Nursery', 13670, 'Quarterly', 9),
(128, 'Nursery', 13853, 'Monthly', 9),
(129, 'Junior Kinder', 12670, 'Fullpayment', 9),
(130, 'Junior Kinder', 12970, 'Semi-Annual', 9),
(131, 'Junior Kinder', 13670, 'Quarterly', 9),
(132, 'Junior Kinder', 13853, 'Monthly', 9),
(133, 'Senior Kinder', 12670, 'Fullpayment', 9),
(134, 'Senior Kinder', 12970, 'Semi-Annual', 9),
(135, 'Senior Kinder', 13670, 'Quarterly', 9),
(136, 'Senior Kinder', 13853, 'Monthly', 9),
(137, 'Grade 1', 14757, 'Fullpayment', 9),
(138, 'Grade 1', 15057, 'Semi-Annual', 9),
(139, 'Grade 1', 15755, 'Quarterly', 9),
(140, 'Grade 1', 16102, 'Monthly', 9),
(141, 'Grade 2', 14757, 'Fullpayment', 9),
(142, 'Grade 2', 15057, 'Semi-Annual', 9),
(143, 'Grade 2', 15755, 'Quarterly', 9),
(144, 'Grade 2', 6102, 'Monthly', 9),
(145, 'Grade 3', 14757, 'Fullpayment', 9),
(146, 'Grade 3', 15057, 'Semi-Annual', 9),
(147, 'Grade 3', 15755, 'Quarterly', 9),
(148, 'Grade 3', 16102, 'Monthly', 9),
(149, 'Grade 4', 15029, 'Fullpayment', 9),
(150, 'Grade 4', 15329, 'Semi-Annual', 9),
(151, 'Grade 4', 16029, 'Quarterly', 9),
(152, 'Grade 4', 16419, 'Monthly', 9),
(153, 'Grade 5', 15029, 'Fullpayment', 9),
(154, 'Grade 5', 15329, 'Semi-Annual', 9),
(155, 'Grade 5', 16029, 'Quarterly', 9),
(156, 'Grade 5', 16419, 'Monthly', 9),
(157, 'Grade 6', 15029, 'Fullpayment', 9),
(158, 'Grade 6', 15329, 'Semi-Annual', 9),
(159, 'Grade 6', 16029, 'Quarterly', 9),
(160, 'Grade 6', 16419, 'Monthly', 9),
(161, 'Grade 7', 19800, 'Fullpayment', 9),
(162, 'Grade 7', 20100, 'Semi-Annual', 9),
(163, 'Grade 7', 20520, 'Quarterly', 9),
(164, 'Grade 7', 21500, 'Monthly', 9),
(165, 'Grade 8', 21000, 'Fullpayment', 9),
(166, 'Grade 8', 21350, 'Semi-Annual', 9),
(167, 'Grade 8', 21750, 'Quarterly', 9),
(168, 'Grade 8', 22050, 'Monthly', 9),
(169, 'Grade 9', 22100, 'Fullpayment', 9),
(170, 'Grade 9', 22400, 'Semi-Annual', 9),
(171, 'Grade 9', 22920, 'Quarterly', 9),
(172, 'Grade 9', 23420, 'Monthly', 9),
(173, 'Grade 10', 23200, 'Fullpayment', 9),
(174, 'Grade 10', 23400, 'Semi-Annual', 9),
(175, 'Grade 10', 23850, 'Quarterly', 9),
(176, 'Grade 10', 24150, 'Monthly', 9),
(177, 'Nursery', 12670, 'Fullpayment', 8),
(178, 'Nursery', 12970, 'Semi-Annual', 8),
(179, 'Nursery', 13670, 'Quarterly', 8),
(180, 'Nursery', 13853, 'Monthly', 8),
(181, 'Junior Kinder', 12670, 'Fullpayment', 8),
(182, 'Junior Kinder', 12970, 'Semi-Annual', 8),
(183, 'Junior Kinder', 13670, 'Quarterly', 8),
(184, 'Junior Kinder', 13853, 'Monthly', 8),
(185, 'Senior Kinder', 12670, 'Fullpayment', 8),
(186, 'Senior Kinder', 12970, 'Semi-Annual', 8),
(187, 'Senior Kinder', 13670, 'Quarterly', 8),
(188, 'Senior Kinder', 13853, 'Monthly', 8),
(189, 'Grade 1', 14757, 'Fullpayment', 8),
(190, 'Grade 1', 15057, 'Semi-Annual', 8),
(191, 'Grade 1', 15755, 'Quarterly', 8),
(192, 'Grade 1', 16102, 'Monthly', 8),
(193, 'Grade 2', 14757, 'Fullpayment', 8),
(194, 'Grade 2', 15057, 'Semi-Annual', 8),
(195, 'Grade 2', 15755, 'Quarterly', 8),
(196, 'Grade 2', 16102, 'Monthly', 8),
(197, 'Grade 3', 14757, 'Fullpayment', 8),
(198, 'Grade 3', 15057, 'Semi-Annual', 8),
(199, 'Grade 3', 15755, 'Quarterly', 8),
(200, 'Grade 3', 16102, 'Monthly', 8),
(201, 'Grade 4', 15029, 'Fullpayment', 8),
(202, 'Grade 4', 15329, 'Semi-Annual', 8),
(203, 'Grade 4', 16029, 'Quarterly', 8),
(204, 'Grade 4', 16419, 'Monthly', 8),
(205, 'Grade 5', 15029, 'Fullpayment', 8),
(206, 'Grade 5', 15329, 'Semi-Annual', 8),
(207, 'Grade 5', 16029, 'Quarterly', 8),
(208, 'Grade 5', 16419, 'Monthly', 8),
(209, 'Grade 6', 15029, 'Fullpayment', 8),
(210, 'Grade 6', 15329, 'Semi-Annual', 8),
(211, 'Grade 6', 16029, 'Quarterly', 8),
(212, 'Grade 6', 16419, 'Monthly', 8),
(213, 'Grade 7', 19800, 'Fullpayment', 8),
(214, 'Grade 7', 20100, 'Semi-Annual', 8),
(215, 'Grade 7', 20520, 'Quarterly', 8),
(216, 'Grade 7', 21500, 'Monthly', 8),
(217, 'Grade 8', 21000, 'Fullpayment', 8),
(218, 'Grade 8', 21350, 'Semi-Annual', 8),
(219, 'Grade 8', 21750, 'Quarterly', 8),
(220, 'Grade 8', 22050, 'Monthly', 8),
(221, 'Grade 9', 22100, 'Fullpayment', 8),
(222, 'Grade 9', 22400, 'Semi-Annual', 8),
(223, 'Grade 9', 22920, 'Quarterly', 8),
(224, 'Grade 9', 23420, 'Monthly', 8),
(225, 'Grade 10', 23200, 'Fullpayment', 8),
(226, 'Grade 10', 23400, 'Semi-Annual', 8),
(227, 'Grade 10', 23850, 'Quarterly', 8),
(228, 'Grade 10', 24150, 'Monthly', 8);

-- --------------------------------------------------------

--
-- Table structure for table `useraccounts`
--

CREATE TABLE `useraccounts` (
  `acc_id` varchar(255) NOT NULL,
  `Firstname` text NOT NULL,
  `Middlename` text NOT NULL,
  `Lastname` text NOT NULL,
  `Username` text NOT NULL,
  `Password` text NOT NULL,
  `Role` text NOT NULL,
  `Status` text NOT NULL,
  `create_at` varchar(50) NOT NULL,
  `isPaswordChanged` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `useraccounts`
--

INSERT INTO `useraccounts` (`acc_id`, `Firstname`, `Middlename`, `Lastname`, `Username`, `Password`, `Role`, `Status`, `create_at`, `isPaswordChanged`) VALUES
('CST-2003-8968', 'Khristine', 'Guinto', 'Badiana', 'B.Khristine Joy', '12345678', 'System Admin', 'Offline', '2019-10-29 09:59:10', 1),
('CST-2018-1059', 'Daniel', '', 'Doronilla', 'D.Daniel', '12345678', 'Teacher', 'Offline', '07/06/2020  04:51:46 PM', 1),
('CST-2018-1328', 'Jacob', 'C', 'Alapapara', 'A.Jacob', '12345678', 'Teacher', 'Offline', '06/19/2020  07:28:57 PM', 1),
('CST-2018-1592', 'Jelleen', '', 'Isidro', 'I.Jelleen', '12345678', 'Teacher', 'Offline', '07/06/2020  06:04:23 PM', 1),
('CST-2018-1699', 'Gady', '', 'Molina', 'M.Gady', '12345678', 'Teacher', 'Offline', '06/19/2020  07:31:54 PM', 1),
('CST-2018-1750', 'Brylle', 'H', 'Poblete', 'P.Brylle', '12345678', 'Teacher', 'Online', '06/19/2020  07:45:43 PM', 1),
('CST-2018-1937', 'Ernilyn', 'H', 'Daza', 'D.Ernilyn', '3M4GJBAF', 'Teacher', 'Offline', '06/19/2020  07:40:10 PM', 0),
('CST-2018-2099', 'Rommel', '', 'Garcia', 'G.Rommel', 'DP7JXOB1', 'Teacher', 'Offline', '06/19/2020  07:30:39 PM', 0),
('CST-2018-2162', 'Benedict', '', 'Croox', 'C.Benedict', 'Y48FF1XK', 'Teacher', 'Offline', '06/19/2020  07:31:24 PM', 0),
('CST-2018-2286', 'Erickick', '', 'Santiano', 'S.Erickick', 'E21WDBS5', 'Teacher', 'Offline', '07/06/2020  06:03:08 PM', 0),
('CST-2018-2391', 'Athens', '', 'Bolangaita', 'B.Athens', 'IFEWUPY2', 'Teacher', 'Offline', '07/06/2020  06:09:41 PM', 0),
('CST-2018-2647', 'Shain', 'K', 'Nasalita', 'N.Shain', '12345678', 'Teacher', 'Offline', '06/19/2020  07:45:10 PM', 1),
('CST-2018-2687', 'Xena', '', 'Vergara', 'V.Xena', 'A5WOLD7Q', 'Teacher', 'Offline', '07/06/2020  04:46:55 PM', 0),
('CST-2018-351', 'Oskhe', '', 'Villanuea', 'V.Oskhe', '3ROCOQFR', 'Teacher', 'Offline', '07/06/2020  04:50:33 PM', 0),
('CST-2018-3750', 'Jomar', '', 'Saldivar', 'S.Jomar', 'HCBUP5JB', 'Teacher', 'Offline', '07/06/2020  06:08:58 PM', 0),
('CST-2018-4071', 'Angel', 'Dela Cruz', 'Cunanan', 'C.Angel', '12345678', 'Teacher', 'Offline', '06/19/2020  08:29:34 PM', 1),
('CST-2018-4526', 'Kimjie', '', 'Gimoto', 'G.Kimjie', '1C9APCOU', 'Teacher', 'Offline', '07/06/2020  04:52:50 PM', 0),
('CST-2018-4822', 'Jason', '', 'Sablawon', 'S.Jason', 'NDFGF0CF', 'Teacher', 'Offline', '07/06/2020  04:53:33 PM', 0),
('CST-2018-488', 'Khino', 'G', 'Bencinio', 'B.Khino', '12345678', 'Teacher', 'Offline', '06/19/2020  07:33:00 PM', 1),
('CST-2018-4944', 'Lilibeth', 'H', 'Luciano', 'L.Lilibeth', 'V8X13UTO', 'Teacher', 'Offline', '06/19/2020  07:36:34 PM', 0),
('CST-2018-4953', 'Joseph', 'A', 'Martin', 'M.Joseph', 'GU9YKYBO', 'Teacher', 'Offline', '06/19/2020  07:27:26 PM', 0),
('CST-2018-5010', 'Miguel', '', 'Valenzona', 'V.Miguel', 'PBU77U3R', 'Teacher', 'Offline', '07/06/2020  06:06:23 PM', 0),
('CST-2018-5264', 'Carl', '', 'Montano', 'M.Carl', 'EJZSRXF1', 'Teacher', 'Offline', '07/06/2020  06:05:39 PM', 0),
('CST-2018-5484', 'Evan Richert', '', 'Tan', 'T.Evan Richert', '12345678', 'Teacher', 'Offline', '06/19/2020  08:32:25 PM', 1),
('CST-2018-5543', 'Alea', 'B', 'Gamaya', 'G.Alea', 'S9SEFBR5', 'Teacher', 'Offline', '06/19/2020  07:32:40 PM', 0),
('CST-2018-5666', 'Randolf', 'H', 'Mangubat', 'M.Randolf', '12345678', 'Teacher', 'Offline', '06/19/2020  07:44:24 PM', 1),
('CST-2018-5714', 'Jexter', '', 'Suba', 'S.Jexter', '12345678', 'Teacher', 'Offline', '06/19/2020  07:32:18 PM', 1),
('CST-2018-6052', 'Zyra', '', 'Albrio', 'A.Zyra', 'BGECUWK9', 'Teacher', 'Offline', '07/06/2020  06:05:57 PM', 0),
('CST-2018-6126', 'Arnulf', '', 'Ariola', 'A.Arnulf', 'FWQ8JBZP', 'Teacher', 'Offline', '07/06/2020  04:45:27 PM', 0),
('CST-2018-6150', 'Jenny', 'Cruz', 'Reyes', 'R.Jenny', 'WFJM556S', 'Teacher', 'Offline', '06/19/2020  08:31:16 PM', 0),
('CST-2018-6292', 'Mark', '', 'Tagle', 'T.Mark', 'BUH1FQPC', 'Teacher', 'Offline', '07/06/2020  06:06:51 PM', 0),
('CST-2018-64', 'Bleu', '', 'Ranoso', 'R.Bleu', 'MD832VES', 'Teacher', 'Offline', '07/06/2020  04:43:24 PM', 0),
('CST-2018-6448', 'Micco', 'G', 'Duran', 'D.Micco', '8G9ET5EL', 'Teacher', 'Offline', '06/19/2020  07:47:59 PM', 0),
('CST-2018-6661', 'Carl', 'Cruz', 'Dela Cruz', 'D.Carl', '12345678', 'Teacher', 'Offline', '06/19/2020  08:30:36 PM', 1),
('CST-2018-6819', 'Richard', 'Cunanan', 'Guinto', 'G.Richard', 'U47HPYMH', 'Teacher', 'Offline', '06/19/2020  08:27:34 PM', 0),
('CST-2018-6841', 'Jason', '', 'Torio', 'T.Jason', '5YWTUPQI', 'Teacher', 'Offline', '07/06/2020  06:02:20 PM', 0),
('CST-2018-7161', 'Mae', '', 'Gallardo', 'G.Mae', '12345678', 'Teacher', 'Offline', '06/19/2020  07:46:21 PM', 1),
('CST-2018-7352', 'Edman', 'G', 'Pebenito', 'P.Edman', '12345678', 'Teacher', 'Offline', '06/19/2020  07:33:33 PM', 1),
('CST-2018-7526', 'Camille', '', 'Alonzo', 'A.Camille', '87DZ1SOT', 'Teacher', 'Offline', '07/06/2020  06:04:48 PM', 0),
('CST-2018-7629', 'Babylyhn', '', 'Calara', 'C.Babylyhn', 'MMYW2J6Y', 'Teacher', 'Offline', '06/19/2020  07:46:52 PM', 0),
('CST-2018-790', 'Raymart', '', 'Legazpi', 'L.Raymart', 'X699HXVP', 'Teacher', 'Offline', '07/06/2020  04:51:06 PM', 0),
('CST-2018-8015', 'Mark Rian', '', 'Paraiso', 'P.Mark Rian', '6HLTYKY3', 'Teacher', 'Offline', '07/06/2020  04:49:11 PM', 0),
('CST-2018-8222', 'Cristina', '', 'Villamor', 'V.Cristina', 'ZN20DIBS', 'Teacher', 'Offline', '07/06/2020  04:45:57 PM', 0),
('CST-2018-8286', 'Angelo', '', 'Sandique', 'S.Angelo', '5NGG5AEA', 'Teacher', 'Offline', '07/06/2020  06:05:15 PM', 0),
('CST-2018-8715', 'Antonio', '', 'Rodriguez', 'R.Antonio', 'KW0FGAC1', 'Teacher', 'Offline', '06/19/2020  08:28:47 PM', 0),
('CST-2018-8799', 'Ruby', '', 'Icaza', 'I.Ruby', 'O90BE9OO', 'Teacher', 'Offline', '07/06/2020  06:07:38 PM', 0),
('CST-2018-888', 'Regie', '', 'Badoy', 'B.Regie', '1KM9JSZG', 'Teacher', 'Offline', '07/06/2020  04:48:40 PM', 0),
('CST-2018-900', 'Andrei', '', 'Paguo', 'P.Andrei', '9L9PJ1M8', 'Teacher', 'Offline', '07/06/2020  04:49:43 PM', 0),
('CST-2018-9027', 'Joseiah', '', 'Matela', 'M.Joseiah', '0AHT74WX', 'Teacher', 'Offline', '07/06/2020  06:07:16 PM', 0),
('CST-2018-9101', 'Ian', '', 'Khan', 'K.Ian', '9FD5YSU6', 'Teacher', 'Offline', '07/06/2020  06:09:23 PM', 0),
('CST-2018-9610', 'Joan', '', 'Gutierrez', 'G.Joan', 'TWAY9Q1I', 'Cashier', 'Offline', '07/06/2020  04:44:39 PM', 0),
('CST-2018-9638', 'Joshua', 'A', 'Medina', 'M.Joshua', 'KDXH7C0U', 'Teacher', 'Offline', '06/19/2020  07:28:12 PM', 0),
('CST-2018-9666', 'Asher', 'G', 'Giron', 'G.Asher', '12345678', 'Teacher', 'Offline', '06/19/2020  07:35:32 PM', 1),
('CST-2018-9941', 'Adrian', 'V', 'Cabreros', 'C.Adrian', 'KVMH93PT', 'Teacher', 'Offline', '06/19/2020  07:29:28 PM', 0),
('CST-2018-9969', 'Mark Harvy', '', 'Bariso', 'B.Mark Harvy', 'M7KVIR2I', 'Teacher', 'Offline', '07/06/2020  04:46:19 PM', 0),
('CST-2018-9981', 'Micheal', '', 'Odiada', 'O.Micheal', 'B9E38W6G', 'Teacher', 'Offline', '07/06/2020  04:44:02 PM', 0),
('CST-2020-6770', 'Missly Ann', '', 'Davalos', 'D.Missly Ann', '12345678', 'Cashier', 'Offline', '06/19/2020  04:22:25 PM', 1),
('CST-2020-8540', 'Elizabeth', 'Tapic', 'Sombilon', 'S.Elizabeth', '12345678', 'Enrollment Admin', 'Offline', '06/19/2020  04:21:31 PM', 1),
('CST-2020-9406', 'Marisol', 'Asis', 'Jadlocon', 'J.Marisol', '12345678', 'Registrar', 'Offline', '06/19/2020  04:21:03 PM', 1),
('CST-2020-9910', 'Paula', '', 'Uy', 'U.Paula', '12345678', 'Teacher', 'Online', '06/19/2020  04:22:43 PM', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `audit_trail`
--
ALTER TABLE `audit_trail`
  ADD PRIMARY KEY (`audit_id`);

--
-- Indexes for table `classroom`
--
ALTER TABLE `classroom`
  ADD PRIMARY KEY (`classroom_id`),
  ADD KEY `classroom_type` (`classroom_type`);

--
-- Indexes for table `classroom_type`
--
ALTER TABLE `classroom_type`
  ADD PRIMARY KEY (`classroom_type_id`);

--
-- Indexes for table `enrollment_schedule`
--
ALTER TABLE `enrollment_schedule`
  ADD PRIMARY KEY (`enrollment_sched_id`);

--
-- Indexes for table `grade_level`
--
ALTER TABLE `grade_level`
  ADD PRIMARY KEY (`gradelvl_id`);

--
-- Indexes for table `misc_fee`
--
ALTER TABLE `misc_fee`
  ADD PRIMARY KEY (`miscfee_id`);

--
-- Indexes for table `orno`
--
ALTER TABLE `orno`
  ADD PRIMARY KEY (`orNo`),
  ADD KEY `deleteorsno` (`sno`);

--
-- Indexes for table `sched_section`
--
ALTER TABLE `sched_section`
  ADD PRIMARY KEY (`ss_id`),
  ADD KEY `delete` (`teacher_ID`),
  ADD KEY `delete2` (`classroom_id`),
  ADD KEY `de` (`timestamp_id`),
  ADD KEY `asd` (`subject_id`),
  ADD KEY `des` (`sect_id`);

--
-- Indexes for table `school_requirements`
--
ALTER TABLE `school_requirements`
  ADD PRIMARY KEY (`req_id`);

--
-- Indexes for table `school_year`
--
ALTER TABLE `school_year`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `sections`
--
ALTER TABLE `sections`
  ADD PRIMARY KEY (`sect_id`),
  ADD KEY `deletesec` (`teacher_ID`);

--
-- Indexes for table `specialization`
--
ALTER TABLE `specialization`
  ADD PRIMARY KEY (`teacher_ID`),
  ADD KEY `deletespec` (`acc_id`);

--
-- Indexes for table `studentenrolledinfo`
--
ALTER TABLE `studentenrolledinfo`
  ADD PRIMARY KEY (`studentenrolled_id`),
  ADD KEY `deletesno` (`sno`),
  ADD KEY `deletesectss` (`sect_id`);

--
-- Indexes for table `students_requirement`
--
ALTER TABLE `students_requirement`
  ADD PRIMARY KEY (`student_req_id`),
  ADD KEY `sd` (`student_no`),
  ADD KEY `studreqidsde` (`req_id`);

--
-- Indexes for table `student_balance`
--
ALTER TABLE `student_balance`
  ADD PRIMARY KEY (`balance_id`),
  ADD KEY `deletebalance` (`sno`);

--
-- Indexes for table `student_detail`
--
ALTER TABLE `student_detail`
  ADD PRIMARY KEY (`student_id`),
  ADD UNIQUE KEY `sno_2` (`sno`),
  ADD KEY `sno` (`sno`);

--
-- Indexes for table `student_family_details`
--
ALTER TABLE `student_family_details`
  ADD PRIMARY KEY (`student_fam_id`),
  ADD KEY `deletefam` (`sno`);

--
-- Indexes for table `student_grades`
--
ALTER TABLE `student_grades`
  ADD PRIMARY KEY (`studentgrade_id`),
  ADD KEY `deletegrades` (`sno`),
  ADD KEY `deleteteacher` (`teacher_ID`),
  ADD KEY `deletesect` (`sect_id`);

--
-- Indexes for table `student_reservepay`
--
ALTER TABLE `student_reservepay`
  ADD PRIMARY KEY (`reservepay`),
  ADD KEY `deleterserve` (`sno`);

--
-- Indexes for table `stud_history_details`
--
ALTER TABLE `stud_history_details`
  ADD PRIMARY KEY (`stud_his_id`),
  ADD KEY `deletehis` (`sno`);

--
-- Indexes for table `subjects`
--
ALTER TABLE `subjects`
  ADD PRIMARY KEY (`subject_id`),
  ADD KEY `cascadetypesub` (`subject_type_id`);

--
-- Indexes for table `subjectype`
--
ALTER TABLE `subjectype`
  ADD PRIMARY KEY (`sub_type_id`);

--
-- Indexes for table `timestamp`
--
ALTER TABLE `timestamp`
  ADD PRIMARY KEY (`timestamp_id`);

--
-- Indexes for table `tuition_fee`
--
ALTER TABLE `tuition_fee`
  ADD PRIMARY KEY (`tf_id`);

--
-- Indexes for table `useraccounts`
--
ALTER TABLE `useraccounts`
  ADD PRIMARY KEY (`acc_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `audit_trail`
--
ALTER TABLE `audit_trail`
  MODIFY `audit_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=288;

--
-- AUTO_INCREMENT for table `classroom`
--
ALTER TABLE `classroom`
  MODIFY `classroom_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT for table `classroom_type`
--
ALTER TABLE `classroom_type`
  MODIFY `classroom_type_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `enrollment_schedule`
--
ALTER TABLE `enrollment_schedule`
  MODIFY `enrollment_sched_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `grade_level`
--
ALTER TABLE `grade_level`
  MODIFY `gradelvl_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `misc_fee`
--
ALTER TABLE `misc_fee`
  MODIFY `miscfee_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=502;

--
-- AUTO_INCREMENT for table `orno`
--
ALTER TABLE `orno`
  MODIFY `orNo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=58;

--
-- AUTO_INCREMENT for table `sched_section`
--
ALTER TABLE `sched_section`
  MODIFY `ss_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=471;

--
-- AUTO_INCREMENT for table `school_requirements`
--
ALTER TABLE `school_requirements`
  MODIFY `req_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT for table `school_year`
--
ALTER TABLE `school_year`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `sections`
--
ALTER TABLE `sections`
  MODIFY `sect_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=80;

--
-- AUTO_INCREMENT for table `specialization`
--
ALTER TABLE `specialization`
  MODIFY `teacher_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=85;

--
-- AUTO_INCREMENT for table `studentenrolledinfo`
--
ALTER TABLE `studentenrolledinfo`
  MODIFY `studentenrolled_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=40;

--
-- AUTO_INCREMENT for table `students_requirement`
--
ALTER TABLE `students_requirement`
  MODIFY `student_req_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT for table `student_balance`
--
ALTER TABLE `student_balance`
  MODIFY `balance_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;

--
-- AUTO_INCREMENT for table `student_detail`
--
ALTER TABLE `student_detail`
  MODIFY `student_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT for table `student_family_details`
--
ALTER TABLE `student_family_details`
  MODIFY `student_fam_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT for table `student_grades`
--
ALTER TABLE `student_grades`
  MODIFY `studentgrade_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=97;

--
-- AUTO_INCREMENT for table `student_reservepay`
--
ALTER TABLE `student_reservepay`
  MODIFY `reservepay` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `stud_history_details`
--
ALTER TABLE `stud_history_details`
  MODIFY `stud_his_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT for table `subjects`
--
ALTER TABLE `subjects`
  MODIFY `subject_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=143;

--
-- AUTO_INCREMENT for table `subjectype`
--
ALTER TABLE `subjectype`
  MODIFY `sub_type_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `timestamp`
--
ALTER TABLE `timestamp`
  MODIFY `timestamp_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `tuition_fee`
--
ALTER TABLE `tuition_fee`
  MODIFY `tf_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=229;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `classroom`
--
ALTER TABLE `classroom`
  ADD CONSTRAINT `dekete` FOREIGN KEY (`classroom_type`) REFERENCES `classroom_type` (`classroom_type_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `orno`
--
ALTER TABLE `orno`
  ADD CONSTRAINT `deleteorsno` FOREIGN KEY (`sno`) REFERENCES `student_detail` (`sno`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `sched_section`
--
ALTER TABLE `sched_section`
  ADD CONSTRAINT `asd` FOREIGN KEY (`subject_id`) REFERENCES `subjects` (`subject_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `de` FOREIGN KEY (`timestamp_id`) REFERENCES `timestamp` (`timestamp_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `delete` FOREIGN KEY (`teacher_ID`) REFERENCES `specialization` (`teacher_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `delete2` FOREIGN KEY (`classroom_id`) REFERENCES `classroom` (`classroom_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `des` FOREIGN KEY (`sect_id`) REFERENCES `sections` (`sect_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `sections`
--
ALTER TABLE `sections`
  ADD CONSTRAINT `deletesec` FOREIGN KEY (`teacher_ID`) REFERENCES `specialization` (`teacher_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `specialization`
--
ALTER TABLE `specialization`
  ADD CONSTRAINT `deletespec` FOREIGN KEY (`acc_id`) REFERENCES `useraccounts` (`acc_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `studentenrolledinfo`
--
ALTER TABLE `studentenrolledinfo`
  ADD CONSTRAINT `deletesectss` FOREIGN KEY (`sect_id`) REFERENCES `sections` (`sect_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `deletesno` FOREIGN KEY (`sno`) REFERENCES `student_detail` (`sno`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `students_requirement`
--
ALTER TABLE `students_requirement`
  ADD CONSTRAINT `sd` FOREIGN KEY (`student_no`) REFERENCES `student_detail` (`sno`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `studreqidsde` FOREIGN KEY (`req_id`) REFERENCES `school_requirements` (`req_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `student_balance`
--
ALTER TABLE `student_balance`
  ADD CONSTRAINT `deletebalance` FOREIGN KEY (`sno`) REFERENCES `student_detail` (`sno`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `student_family_details`
--
ALTER TABLE `student_family_details`
  ADD CONSTRAINT `deletefam` FOREIGN KEY (`sno`) REFERENCES `student_detail` (`sno`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `student_grades`
--
ALTER TABLE `student_grades`
  ADD CONSTRAINT `deletegrades` FOREIGN KEY (`sno`) REFERENCES `student_detail` (`sno`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `deletesect` FOREIGN KEY (`sect_id`) REFERENCES `sections` (`sect_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `deleteteacher` FOREIGN KEY (`teacher_ID`) REFERENCES `specialization` (`teacher_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `student_reservepay`
--
ALTER TABLE `student_reservepay`
  ADD CONSTRAINT `deleterserve` FOREIGN KEY (`sno`) REFERENCES `student_detail` (`sno`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `stud_history_details`
--
ALTER TABLE `stud_history_details`
  ADD CONSTRAINT `deletehis` FOREIGN KEY (`sno`) REFERENCES `student_detail` (`sno`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `subjects`
--
ALTER TABLE `subjects`
  ADD CONSTRAINT `cascadetypesub` FOREIGN KEY (`subject_type_id`) REFERENCES `subjectype` (`sub_type_id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
