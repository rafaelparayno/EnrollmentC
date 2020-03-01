-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 26, 2020 at 06:00 PM
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
(96, 'February/22/2020  07:24:32 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(97, 'February 22 2020 07:26:09 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(98, 'February/22/2020  07:29:51 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(99, 'February 22 2020 07:30:06 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(100, 'February/22/2020  07:32:41 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(101, 'February 22 2020 07:33:01 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(102, 'February/22/2020  07:49:32 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(103, 'February 22 2020 07:49:50 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(104, 'February/22/2020  07:52:12 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(105, 'February 22 2020 07:52:29 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(106, 'February/22/2020  07:53:48 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(107, 'February 22 2020 07:54:25 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(108, 'February/22/2020  07:56:15 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(109, 'February 22 2020 07:56:37 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(110, 'February/22/2020  08:01:47 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(111, 'February 22 2020 08:02:00 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(112, 'February/22/2020  08:03:50 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(113, 'February 22 2020 08:04:11 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(114, 'February/22/2020  08:14:58 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(115, 'February 22 2020 08:15:24 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(116, 'February/22/2020  08:16:40 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(117, 'February 22 2020 08:17:10 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(118, 'February/22/2020  08:21:00 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(119, 'February 22 2020 08:21:48 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(120, 'February/22/2020  08:55:03 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(121, 'February/22/2020  09:14:37 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(122, 'February/22/2020  09:20:57 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(123, 'February/22/2020  09:23:30 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(124, 'February 22 2020 09:23:46 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(125, 'February/22/2020  09:26:53 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(126, 'February/22/2020  09:37:41 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(127, 'February 22 2020 09:38:25 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(128, 'February/22/2020  09:46:08 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(129, 'February 22 2020 09:47:04 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(130, 'February/22/2020  09:49:43 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(131, 'February 22 2020 09:51:38 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(132, 'February/22/2020  09:58:32 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(133, 'February 22 2020 09:58:56 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(134, 'February/22/2020  10:03:56 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(135, 'February 22 2020 10:04:42 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(136, 'February/22/2020  10:07:17 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(137, 'February 22 2020 10:07:36 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(138, 'February/22/2020  10:09:39 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(139, 'February 22 2020 10:10:28 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(140, 'February/22/2020  10:13:06 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(141, 'February 22 2020 10:13:24 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(142, 'February/22/2020  10:16:24 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(143, 'February 22 2020 10:16:38 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(144, 'February/22/2020  10:18:51 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(145, 'February 22 2020 10:19:07 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(146, 'February/22/2020  10:21:58 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(147, 'February 22 2020 10:22:20 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(148, 'February/22/2020  10:25:33 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(149, 'February 22 2020 10:26:02 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(150, 'February/22/2020  10:32:46 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(151, 'February/22/2020  10:34:27 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(152, 'February 22 2020 10:35:25 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(153, 'February/22/2020  10:37:28 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(154, '02/22/2020  10:37:30 PM', 'Khristine Badiana', 'User successfully activate school year 2021-2022', 'System Admin', 'kbadiana2416'),
(155, 'February 22 2020 10:39:19 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(156, 'February/22/2020  10:41:25 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(157, '02/22/2020  10:41:28 PM', 'Khristine Badiana', 'User successfully activate school year 2022-2023', 'System Admin', 'kbadiana2416'),
(158, 'February 22 2020 10:42:44 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(159, 'February/22/2020  11:24:22 PM', 'Sean Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(160, '02/22/2020  11:24:22 PM', 'Sean Yang', 'User has been Logout', 'Teacher', 'Syang0900'),
(161, 'February/22/2020  11:24:51 PM', 'Ashley Sombilon', 'User has been Login', 'System Admin', 'ASombilon'),
(162, 'February 22 2020 11:24:57 PM', 'Ashley Sombilon', 'User has been Logout', 'System Admin', 'ASombilon'),
(163, 'February/22/2020  11:25:11 PM', 'Rex Harvey Luna', 'User has been Login', 'Registrar', 'Rex14'),
(164, '02/22/2020  11:25:11 PM', 'Rex Harvey Luna', 'User has been Logout', 'Registrar', 'Rex14'),
(165, 'February/22/2020  11:25:31 PM', 'Marisol Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(166, '02/22/2020  11:25:31 PM', 'Marisol Jadlocon', 'User has been Logout', 'Registrar', 'mjadlocon6188'),
(167, 'February/22/2020  11:25:55 PM', 'Paula Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(168, '02/22/2020  11:25:55 PM', 'Paula Uy', 'User has been Logout', 'Enrollment Admin', 'puy4120'),
(169, 'February/22/2020  11:26:17 PM', 'Missly Ann Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(170, 'February/22/2020  11:26:47 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(171, 'February 22 2020 11:27:27 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(172, 'February/22/2020  11:33:58 PM', 'Missly Ann Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(173, '02/22/2020  11:33:58 PM', 'Missly Ann Davalos', 'User has been Logout', 'Cashier', 'mdavalos4028'),
(174, 'February/22/2020  11:34:15 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(175, 'February 22 2020 11:34:38 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(176, 'February/24/2020  11:54:25 AM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(177, '02/24/2020  11:54:28 AM', 'Khristine Badiana', 'User successfully activate school year 2021-2022', 'System Admin', 'kbadiana2416'),
(178, 'February 24 2020 11:58:58 AM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(179, 'February/24/2020  11:59:13 AM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(180, 'February 24 2020 12:00:32 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(181, 'February/24/2020  12:25:08 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(182, '02/24/2020  12:25:10 PM', 'Khristine Badiana', 'User successfully activate school year 2019-2020', 'System Admin', 'kbadiana2416'),
(183, 'February 24 2020 12:26:24 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(184, 'February/24/2020  12:26:30 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(185, 'February/24/2020  12:32:28 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(186, '02/24/2020  12:35:34 PM', 'Khristine Badiana', 'User successfully activate school year 2020-2021', 'System Admin', 'kbadiana2416'),
(187, 'February 24 2020 12:36:12 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(188, 'February/24/2020  12:46:09 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(189, 'February/24/2020  12:54:09 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(190, '02/24/2020  12:54:14 PM', 'Khristine Badiana', 'User successfully activate school year 2020-2021', 'System Admin', 'kbadiana2416'),
(191, 'February/24/2020  12:58:55 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(192, '02/24/2020  12:58:57 PM', 'Khristine Badiana', 'User successfully activate school year 2019-2020', 'System Admin', 'kbadiana2416'),
(193, '02/24/2020  12:58:57 PM', 'Khristine Badiana', 'User successfully activate school year 2024-2025', 'System Admin', 'kbadiana2416'),
(194, '02/24/2020  12:58:57 PM', 'Khristine Badiana', 'User successfully activate school year 2020-2021', 'System Admin', 'kbadiana2416'),
(195, 'February 24 2020 01:00:57 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(196, 'February/24/2020  01:03:17 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(197, 'February/24/2020  01:08:59 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(198, '02/24/2020  01:09:02 PM', 'Khristine Badiana', 'User successfully activate school year 2018-2019', 'System Admin', 'kbadiana2416'),
(199, 'February/24/2020  01:18:46 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(200, '02/24/2020  01:18:47 PM', 'Khristine Badiana', 'User successfully activate school year 2018-2019', 'System Admin', 'kbadiana2416'),
(201, 'February/24/2020  01:21:41 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(202, '02/24/2020  01:21:43 PM', 'Khristine Badiana', 'User successfully activate school year 2018-2019', 'System Admin', 'kbadiana2416'),
(203, '02/24/2020  01:21:43 PM', 'Khristine Badiana', 'User successfully activate school year 2019-2020', 'System Admin', 'kbadiana2416'),
(204, 'February 24 2020 01:23:16 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(205, 'February/24/2020  01:24:20 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(206, 'February 24 2020 01:24:54 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(207, 'February/24/2020  01:35:00 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(208, '02/24/2020  01:35:10 PM', 'Khristine Badiana', 'User successfully activate school year 2018-2019', 'System Admin', 'kbadiana2416'),
(209, '02/24/2020  01:35:10 PM', 'Khristine Badiana', 'User successfully activate school year 2020-2021', 'System Admin', 'kbadiana2416'),
(210, 'February 24 2020 01:36:55 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(211, 'February/24/2020  01:38:09 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(212, 'February/24/2020  01:43:51 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(213, '02/24/2020  01:43:57 PM', 'Khristine Badiana', 'User successfully activate school year 2021-2022', 'System Admin', 'kbadiana2416'),
(214, '02/24/2020  01:43:57 PM', 'Khristine Badiana', 'User successfully activate school year 2019-2020', 'System Admin', 'kbadiana2416'),
(215, 'February 24 2020 01:44:57 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(216, 'February/24/2020  01:48:59 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(217, 'February/24/2020  01:52:18 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(218, 'February/24/2020  01:54:29 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(219, '02/24/2020  01:54:32 PM', 'Khristine Badiana', 'User successfully activate school year 2018-2019', 'System Admin', 'kbadiana2416'),
(220, '02/24/2020  01:54:32 PM', 'Khristine Badiana', 'User successfully activate school year 2021-2022', 'System Admin', 'kbadiana2416'),
(221, 'February 24 2020 01:55:06 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(222, 'February/24/2020  02:02:11 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(223, 'February/24/2020  02:07:53 PM', 'Paula Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(224, 'February/24/2020  02:40:04 PM', 'Paula Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(225, 'February/24/2020  02:52:30 PM', 'Paula Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(226, 'February/24/2020  02:57:36 PM', 'Paula Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(227, 'February/24/2020  03:03:32 PM', 'Paula Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(228, 'February/24/2020  03:05:46 PM', 'Paula Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(229, '02/24/2020  03:05:50 PM', 'Paula Uy', 'User has been Logout', 'Enrollment Admin', 'puy4120'),
(230, 'February/24/2020  03:39:14 PM', 'Paula Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(231, '02/24/2020  03:40:14 PM', 'Paula Uy', 'User has been Logout', 'Enrollment Admin', 'puy4120'),
(232, 'February/24/2020  03:50:03 PM', 'Paula Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(233, '02/24/2020  03:50:15 PM', 'Paula Uy', 'User has been Logout', 'Enrollment Admin', 'puy4120'),
(234, 'February/24/2020  04:01:58 PM', 'Paula Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(235, 'February/24/2020  04:05:01 PM', 'Paula Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(236, 'February/26/2020  12:29:42 AM', 'Marisol Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(237, 'February/26/2020  01:00:37 AM', 'Marisol Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(238, 'February/26/2020  01:22:56 AM', 'Marisol Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(239, 'February/26/2020  01:56:06 AM', 'Marisol Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(240, '02/26/2020  01:56:06 AM', 'Marisol Jadlocon', 'User has been Logout', 'Registrar', 'mjadlocon6188'),
(241, 'February/26/2020  02:20:32 AM', 'Marisol Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(242, '02/26/2020  02:20:41 AM', 'Marisol Jadlocon', 'User has been Logout', 'Registrar', 'mjadlocon6188'),
(243, 'February/26/2020  02:20:56 AM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(244, 'February 26 2020 02:21:16 AM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(245, 'February/26/2020  02:24:33 AM', 'Marisol Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(246, '02/26/2020  02:24:54 AM', 'Marisol Jadlocon', 'User has been Logout', 'Registrar', 'mjadlocon6188'),
(247, 'February/26/2020  02:27:21 AM', 'Marisol Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(248, 'February/26/2020  02:38:11 AM', 'Marisol Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(249, 'February/26/2020  02:51:22 AM', 'Marisol Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(250, 'February/26/2020  02:54:28 AM', 'Marisol Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(251, '02/26/2020  02:56:55 AM', 'Marisol Jadlocon', 'User has been Logout', 'Registrar', 'mjadlocon6188'),
(252, 'February/26/2020  03:01:14 AM', 'Marisol Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(253, '02/26/2020  03:01:49 AM', 'Marisol Jadlocon', 'User has been Logout', 'Registrar', 'mjadlocon6188'),
(254, 'February/26/2020  03:03:27 AM', 'Marisol Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(255, '02/26/2020  03:03:51 AM', 'Marisol Jadlocon', 'User has been Logout', 'Registrar', 'mjadlocon6188'),
(256, 'February/26/2020  03:13:06 AM', 'Marisol Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(257, '02/26/2020  03:13:42 AM', 'Marisol Jadlocon', 'User has been Logout', 'Registrar', 'mjadlocon6188'),
(258, 'February/26/2020  03:34:33 AM', 'Marisol Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(259, 'February/26/2020  03:39:59 AM', 'Marisol Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(260, 'February/26/2020  03:41:13 AM', 'Marisol Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(261, 'February/26/2020  03:42:46 AM', 'Marisol Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(262, 'February/26/2020  03:44:26 AM', 'Marisol Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(263, '02/26/2020  03:45:56 AM', 'Marisol Jadlocon', 'User has been Logout', 'Registrar', 'mjadlocon6188'),
(264, 'February/26/2020  03:48:58 AM', 'Marisol Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(265, '02/26/2020  03:50:29 AM', 'Marisol Jadlocon', 'User has been Logout', 'Registrar', 'mjadlocon6188'),
(266, 'February/26/2020  04:14:28 AM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(267, '02/26/2020  04:15:34 AM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(268, 'February/26/2020  04:18:29 AM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(269, '02/26/2020  04:19:24 AM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(270, 'February/26/2020  04:34:10 AM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(271, '02/26/2020  04:35:28 AM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(272, 'February/26/2020  04:39:51 AM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(273, '02/26/2020  04:40:27 AM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(274, 'February/26/2020  04:41:30 AM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(275, '02/26/2020  04:42:18 AM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(276, 'February/26/2020  02:14:30 PM', 'Sean Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(277, '02/26/2020  02:14:30 PM', 'Sean Yang', 'User has been Logout', 'Teacher', 'Syang0900'),
(278, 'February/26/2020  02:17:29 PM', 'Sean Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(279, '02/26/2020  02:17:50 PM', 'Sean Yang', 'User has been Logout', 'Teacher', 'Syang0900'),
(280, 'February/26/2020  02:17:55 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(281, '02/26/2020  02:18:38 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(282, '02/26/2020  04:18:04 PM', 'Missly Ann Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(283, '02/26/2020  04:20:49 PM', 'Missly Ann Davalos', 'User has been Logout', 'Cashier', 'mdavalos4028'),
(284, '02/26/2020  04:23:08 PM', 'Missly Ann Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(285, '02/26/2020  04:23:48 PM', 'Missly Ann Davalos', 'User has been Logout', 'Cashier', 'mdavalos4028'),
(286, '02/26/2020  04:27:54 PM', 'Missly Ann Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(287, '02/26/2020  04:29:55 PM', 'Missly Ann Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(288, '02/26/2020  04:38:49 PM', 'Marisol Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(289, '02/26/2020  04:42:15 PM', 'Marisol Jadlocon', 'User has been Logout', 'Registrar', 'mjadlocon6188'),
(290, '02/26/2020  10:24:57 PM', 'Marisol Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(291, '02/26/2020  10:25:54 PM', 'Marisol Jadlocon', 'User has been Logout', 'Registrar', 'mjadlocon6188'),
(292, '02/26/2020  10:32:25 PM', 'Marisol Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(293, '02/26/2020  10:35:00 PM', 'Marisol Jadlocon', 'User has been Logout', 'Registrar', 'mjadlocon6188'),
(294, '02/26/2020  10:35:14 PM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(295, '02/26/2020  10:35:53 PM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(296, '02/26/2020  10:36:27 PM', 'Sean Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(297, '02/26/2020  10:36:43 PM', 'Sean Yang', 'User has been Logout', 'Teacher', 'Syang0900'),
(298, '02/26/2020  10:38:05 PM', 'Missly Ann Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(299, '02/26/2020  10:40:40 PM', 'Missly Ann Davalos', 'User has been Logout', 'Cashier', 'mdavalos4028'),
(300, '02/26/2020  10:40:48 PM', 'Paula Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(301, '02/26/2020  10:53:49 PM', 'Missly Ann Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(302, '02/26/2020  10:54:51 PM', 'Missly Ann Davalos', 'User has been Logout', 'Cashier', 'mdavalos4028'),
(303, '02/27/2020  12:19:36 AM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(304, '02/27/2020  12:19:40 AM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416'),
(305, '02/27/2020  12:19:46 AM', 'Sean Yang', 'User has been Login', 'Teacher', 'Syang0900'),
(306, '02/27/2020  12:20:04 AM', 'Sean Yang', 'User has been Logout', 'Teacher', 'Syang0900'),
(307, '02/27/2020  12:21:08 AM', 'Missly Ann Davalos', 'User has been Login', 'Cashier', 'mdavalos4028'),
(308, '02/27/2020  12:22:21 AM', 'Missly Ann Davalos', 'User has been Logout', 'Cashier', 'mdavalos4028'),
(309, '02/27/2020  12:22:28 AM', 'Marisol Jadlocon', 'User has been Login', 'Registrar', 'mjadlocon6188'),
(310, '02/27/2020  12:23:36 AM', 'Marisol Jadlocon', 'User has been Logout', 'Registrar', 'mjadlocon6188'),
(311, '02/27/2020  12:31:45 AM', 'Paula Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(312, '02/27/2020  12:31:55 AM', 'Paula Uy', 'User has been Logout', 'Enrollment Admin', 'puy4120'),
(313, '02/27/2020  12:32:46 AM', 'Paula Uy', 'User has been Login', 'Enrollment Admin', 'puy4120'),
(314, '02/27/2020  12:36:01 AM', 'Paula Uy', 'User has been Logout', 'Enrollment Admin', 'puy4120'),
(315, '02/27/2020  12:36:15 AM', 'Khristine Badiana', 'User has been Login', 'System Admin', 'kbadiana2416'),
(316, '02/27/2020  12:38:52 AM', 'Khristine Badiana', 'User has been Logout', 'System Admin', 'kbadiana2416');

-- --------------------------------------------------------

--
-- Table structure for table `classroom`
--

CREATE TABLE `classroom` (
  `classroom_id` int(11) NOT NULL,
  `classroom_type` text NOT NULL,
  `classroom_no` int(11) NOT NULL,
  `SY` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `class_schedule`
--

CREATE TABLE `class_schedule` (
  `grade_level` text NOT NULL,
  `section` text NOT NULL,
  `subject` text NOT NULL,
  `teacher` text NOT NULL,
  `time_start` text NOT NULL,
  `time_end` text NOT NULL,
  `day` text NOT NULL,
  `classroom` text NOT NULL,
  `SY` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `enrollment_schedule`
--

CREATE TABLE `enrollment_schedule` (
  `enrollment_type` varchar(150) NOT NULL,
  `discount` double NOT NULL,
  `start_date` text NOT NULL,
  `end_date` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `enrollment_schedule`
--

INSERT INTO `enrollment_schedule` (`enrollment_type`, `discount`, `start_date`, `end_date`) VALUES
('Regular Enrollment', 0, '10/29/2019', '10/30/2019');

-- --------------------------------------------------------

--
-- Table structure for table `grade_level`
--

CREATE TABLE `grade_level` (
  `grade_type` text NOT NULL,
  `grade_level` text NOT NULL,
  `SY` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `misc_fee`
--

CREATE TABLE `misc_fee` (
  `details` text NOT NULL,
  `price` int(11) NOT NULL,
  `grade_level` text NOT NULL,
  `SY` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `school_requirements`
--

CREATE TABLE `school_requirements` (
  `type_of_student` text NOT NULL,
  `requirement` text NOT NULL,
  `SY` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `school_year`
--

CREATE TABLE `school_year` (
  `school_year` varchar(9) NOT NULL,
  `sy_status` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `school_year`
--

INSERT INTO `school_year` (`school_year`, `sy_status`) VALUES
('2018-2019', 'activate');

-- --------------------------------------------------------

--
-- Table structure for table `sections`
--

CREATE TABLE `sections` (
  `grade_level` text NOT NULL,
  `adviser` text NOT NULL,
  `section` text NOT NULL,
  `SY` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sections`
--

INSERT INTO `sections` (`grade_level`, `adviser`, `section`, `SY`) VALUES
('', '', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `specialization`
--

CREATE TABLE `specialization` (
  `teacher_ID` text NOT NULL,
  `teacher_username` text NOT NULL,
  `grade_level` text NOT NULL,
  `bachelor_degree` text NOT NULL,
  `subject` text NOT NULL,
  `SY` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `subjects`
--

CREATE TABLE `subjects` (
  `grade_level` text NOT NULL,
  `subject` text NOT NULL,
  `subj_duration` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tuition_fee`
--

CREATE TABLE `tuition_fee` (
  `grade_level` text NOT NULL,
  `tuition_fee` double NOT NULL,
  `mode_of_payment` text NOT NULL,
  `increase` double NOT NULL,
  `SY` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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
  `create_at` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `useraccounts`
--

INSERT INTO `useraccounts` (`acc_id`, `Firstname`, `Middlename`, `Lastname`, `Username`, `Password`, `Role`, `Status`, `create_at`) VALUES
('CST-2003-0850', 'Missly Ann', 'Manabat', 'Davalos', 'mdavalos4028', '431187', 'Cashier', 'Offline', '2019-10-29 10:01:44'),
('CST-2003-0909', 'Sean', '', 'Yang', 'Syang0900', '123456', 'Teacher', 'Offline', ''),
('CST-2003-2004', 'Paula', 'Crisostomo', 'Uy', 'puy4120', '1234567', 'Enrollment Admin', 'Offline', '2019-10-29 10:01:56'),
('CST-2003-8968', 'Khristine', 'Guinto', 'Badiana', 'kbadiana2416', '12345678', 'System Admin', 'Offline', '2019-10-29 09:59:10'),
('CST-2003-9768', 'Marisol', 'Amaro', 'Jadlocon', 'mjadlocon6188', '12345678', 'Registrar', 'Offline', '2019-10-29 10:01:25'),
('CST-2013-3020', 'Ashley', 'tapic', 'Sombilon', 'ASombilon', '123456', 'System Admin', 'Offline', 'February/21/2020  12:30:34 PM'),
('CST-2013-5817', 'Rex Harvey', 'Runa', 'Luna', 'Rex14', '12345', 'Registrar', 'Offline', 'February/21/2020  02:50:41 PM');

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
  ADD PRIMARY KEY (`classroom_id`);

--
-- Indexes for table `enrollment_schedule`
--
ALTER TABLE `enrollment_schedule`
  ADD PRIMARY KEY (`enrollment_type`);

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
  MODIFY `audit_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=317;

--
-- AUTO_INCREMENT for table `classroom`
--
ALTER TABLE `classroom`
  MODIFY `classroom_id` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
