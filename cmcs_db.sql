-- phpMyAdmin SQL Dump
-- version 4.0.4
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Jul 23, 2014 at 12:21 PM
-- Server version: 5.6.12-log
-- PHP Version: 5.4.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `cmcs_db`
--
CREATE DATABASE IF NOT EXISTS `cmcs_db` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `cmcs_db`;

-- --------------------------------------------------------

--
-- Table structure for table `cmcs_account`
--

CREATE TABLE IF NOT EXISTS `cmcs_account` (
  `member_id` int(11) NOT NULL,
  `account_no` int(11) NOT NULL AUTO_INCREMENT,
  `no_of_shares` int(11) DEFAULT NULL,
  `minimum_balance` int(11) NOT NULL,
  `date_of_change` date DEFAULT NULL,
  `interest` double NOT NULL,
  PRIMARY KEY (`account_no`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=10003 ;

--
-- Dumping data for table `cmcs_account`
--

INSERT INTO `cmcs_account` (`member_id`, `account_no`, `no_of_shares`, `minimum_balance`, `date_of_change`, `interest`) VALUES
(788, 1, 0, 5600, '2014-07-03', 0),
(789, 2, 0, 0, '0000-00-00', 0),
(0, 10000, 88, 77, '0000-00-00', 0),
(790, 10001, 500, 20000, '0000-00-00', 0),
(791, 10002, 500, 20000, '0000-00-00', 0);

-- --------------------------------------------------------

--
-- Table structure for table `cmcs_loan_registration`
--

CREATE TABLE IF NOT EXISTS `cmcs_loan_registration` (
  `loan_id` int(11) NOT NULL AUTO_INCREMENT,
  `member_id` int(11) DEFAULT NULL,
  `loan_type_id` varchar(255) DEFAULT NULL,
  `witness1_id` int(11) DEFAULT NULL,
  `witness1_name` varchar(40) NOT NULL,
  `witness1_contact` varchar(12) NOT NULL,
  `witness2_id` int(11) DEFAULT NULL,
  `witness2_name` varchar(40) NOT NULL,
  `witness2_contact` varchar(12) NOT NULL,
  `date_of_granting` datetime DEFAULT NULL,
  `loan_amount` int(11) DEFAULT NULL,
  `balance_due` double NOT NULL,
  `interest` double NOT NULL,
  `status` bit(1) DEFAULT b'1',
  PRIMARY KEY (`loan_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=10003 ;

--
-- Dumping data for table `cmcs_loan_registration`
--

INSERT INTO `cmcs_loan_registration` (`loan_id`, `member_id`, `loan_type_id`, `witness1_id`, `witness1_name`, `witness1_contact`, `witness2_id`, `witness2_name`, `witness2_contact`, `date_of_granting`, `loan_amount`, `balance_due`, `interest`, `status`) VALUES
(10001, 54, 'l1', 786, 'Ajeet Khan', '21', 787, 'W', 'W', '2014-07-15 00:00:00', 7687878, 7678889, 0, b'1'),
(10002, 54, 'l1', 156, 'sunny', '7869851872', 501, 'aaaaaaa', '23', '2014-07-17 00:00:00', 7800, 7800, 0, b'1');

-- --------------------------------------------------------

--
-- Table structure for table `cmcs_loan_transaction`
--

CREATE TABLE IF NOT EXISTS `cmcs_loan_transaction` (
  `reciept_no` int(11) NOT NULL AUTO_INCREMENT,
  `date_of_payment` datetime DEFAULT NULL,
  `intallment_amount` int(11) DEFAULT NULL,
  `mode_of_payment` varchar(255) DEFAULT NULL,
  `cheque_no` varchar(255) DEFAULT NULL,
  `amount_due` int(11) DEFAULT NULL,
  `loan_id` int(11) DEFAULT NULL,
  `interest` float NOT NULL,
  `member_id` int(11) NOT NULL,
  PRIMARY KEY (`reciept_no`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=67 ;

--
-- Dumping data for table `cmcs_loan_transaction`
--

INSERT INTO `cmcs_loan_transaction` (`reciept_no`, `date_of_payment`, `intallment_amount`, `mode_of_payment`, `cheque_no`, `amount_due`, `loan_id`, `interest`, `member_id`) VALUES
(1, '2013-12-02 00:00:00', 4, 'cash', NULL, 79, NULL, 0, 786),
(45, '2013-07-10 00:00:00', 5222, 'Cash', ' - ', 7865, 12, 2952.93, 54),
(46, '2014-07-13 00:00:00', 200, 'Cash', ' - ', 0, 687, 0, 786),
(47, '2014-07-13 00:00:00', 200, 'Cash', ' - ', 0, 687, 0, 786),
(48, '2014-07-13 00:00:00', 200, 'Cash', ' - ', 0, 687, 0, 786),
(49, '2014-07-13 00:00:00', 200, 'Cash', ' - ', 0, 687, 0, 786),
(50, '2014-07-13 00:00:00', 200, 'Cash', ' - ', 0, 687, 0, 786),
(51, '2014-07-13 00:00:00', 200, 'Cash', ' - ', 0, 687, 0, 786),
(52, '2014-07-13 00:00:00', 200, 'Cash', ' - ', 6550, 12, 0, 54),
(53, '2014-07-13 00:00:00', 200, 'Cash', ' - ', 6550, 12, 0, 54),
(54, '2014-07-13 00:00:00', 200, 'Cash', ' - ', 6550, 12, 0, 54),
(55, '2014-07-13 00:00:00', 200, 'Cash', ' - ', 6550, 12, 0, 54),
(56, '2014-07-13 00:00:00', 200, 'Cash', ' - ', 6550, 12, 0, 54),
(57, '2014-07-13 00:00:00', 200, 'Cash', ' - ', 6550, 12, 0, 54),
(58, '2014-07-13 00:00:00', 350, 'Cash', ' - ', 6350, 12, 0, 54),
(59, '2014-07-13 00:00:00', 500, 'Cash', ' - ', 6000, 12, 0, 54),
(60, '2014-07-13 00:00:00', 500, 'Cash', ' - ', 5500, 12, 0, 54),
(61, '2014-07-13 00:00:00', 5, 'Cash', ' - ', 5000, 12, 0, 54),
(62, '2014-07-13 00:00:00', 500, 'Cash', ' - ', 4995, 12, 0, 54),
(63, '2014-07-14 00:00:00', 211111, '', '', 500000, 12, 0, 54),
(64, '2014-07-14 00:00:00', 211111, 'Cash', ' - ', 500000, 12, 0, 54),
(65, '2014-07-15 00:00:00', 7878, 'Cash', ' - ', 65576, 0, 0, 54),
(66, '2014-07-15 00:00:00', 8989, 'Cash', ' - ', 7687878, 10001, 0, 54);

-- --------------------------------------------------------

--
-- Table structure for table `cmcs_loan_type`
--

CREATE TABLE IF NOT EXISTS `cmcs_loan_type` (
  `loan_type_id` varchar(30) NOT NULL,
  `type` varchar(255) DEFAULT NULL,
  `rate_of_interest` int(11) DEFAULT NULL,
  PRIMARY KEY (`loan_type_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `cmcs_loan_type`
--

INSERT INTO `cmcs_loan_type` (`loan_type_id`, `type`, `rate_of_interest`) VALUES
('l1', 'personal', 12);

-- --------------------------------------------------------

--
-- Table structure for table `cmcs_login`
--

CREATE TABLE IF NOT EXISTS `cmcs_login` (
  `uid` varchar(255) NOT NULL DEFAULT '',
  `pass` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`uid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `cmcs_login`
--

INSERT INTO `cmcs_login` (`uid`, `pass`) VALUES
('admin', 'a');

-- --------------------------------------------------------

--
-- Table structure for table `cmcs_member_master`
--

CREATE TABLE IF NOT EXISTS `cmcs_member_master` (
  `member_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL DEFAULT '',
  `gaurdian_name` varchar(255) DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  `date_of_birth` datetime DEFAULT NULL,
  `qualification` varchar(255) DEFAULT NULL,
  `department` varchar(255) DEFAULT NULL,
  `branch` varchar(255) DEFAULT NULL,
  `designation` varchar(255) DEFAULT NULL,
  `date_of_joining` datetime DEFAULT NULL,
  `gross_salary` int(11) DEFAULT NULL,
  `number_of _family_member` int(11) DEFAULT NULL,
  `contact_no` varchar(15) DEFAULT NULL,
  `witness1_id` int(11) DEFAULT NULL,
  `witness1_name` varchar(255) NOT NULL,
  `witness1_contact_no` varchar(15) NOT NULL,
  `witness2_id` int(11) DEFAULT NULL,
  `witness2_name` varchar(255) NOT NULL,
  `witness2_contact_no` varchar(15) NOT NULL,
  `category` varchar(255) DEFAULT NULL,
  `gender` varchar(255) DEFAULT NULL,
  `date_of_leaving` datetime DEFAULT NULL,
  `is_active` bit(1) NOT NULL COMMENT '1 for active',
  `blood_group` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`member_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=792 ;

--
-- Dumping data for table `cmcs_member_master`
--

INSERT INTO `cmcs_member_master` (`member_id`, `name`, `gaurdian_name`, `address`, `date_of_birth`, `qualification`, `department`, `branch`, `designation`, `date_of_joining`, `gross_salary`, `number_of _family_member`, `contact_no`, `witness1_id`, `witness1_name`, `witness1_contact_no`, `witness2_id`, `witness2_name`, `witness2_contact_no`, `category`, `gender`, `date_of_leaving`, `is_active`, `blood_group`) VALUES
(54, 'hbvvbnmbmnbbkjbmbmnbmnnitesh', 'n', 'indore madhya pradesh', '2014-05-25 00:00:00', 'n', 'n', 'n', 'n', '2014-05-25 00:00:00', 9087, 5, '9039541197', NULL, '', '0', NULL, '', '0', NULL, NULL, NULL, b'1', NULL),
(156, 'sunny', 'm', 'mmmmm', '1993-05-28 00:00:00', 'm', 'mmmm', 'mmm', 'm', '2013-05-28 00:00:00', 87666, 4, '7869851872', NULL, '', '0', NULL, '', '0', 'General', 'Male', NULL, b'0', NULL),
(501, 'aaaaaaa', 'a', 'indore madhya pradesh', '2004-05-07 00:00:00', 'a', 'a', 'a', 'a', '2014-05-08 00:00:00', 3444, 3, '23', 45, '', '0', 43, '', '0', NULL, NULL, NULL, b'0', NULL),
(786, 'Ajeet Khan', 'xyz', 'Mhow', '1991-12-09 00:00:00', 'bca', 'abc', 'abc', 'xyz', '2011-12-09 00:00:00', 0, 0, '21', 54, 'Nitesh', '9039541197', 156, 'sunny', '7869851872', 'OBC', 'Male', '0000-00-00 00:00:00', b'0', 'o+'),
(787, 'W', 'W', 'W', '2014-07-13 00:00:00', 'W', 'W', 'W', 'W', '2014-07-13 00:00:00', 0, 0, 'W', 0, '', '', 0, '', '', 'W', 'Male', '0000-00-00 00:00:00', b'1', 'W'),
(788, 'W', 'W', 'W', '2014-07-13 00:00:00', 'W', 'W', 'W', 'W', '2014-07-13 00:00:00', 0, 0, 'W', 0, '', '', 0, '', '', 'W', 'Male', '0000-00-00 00:00:00', b'0', 'W'),
(789, 'W', 'W', 'W', '2014-07-13 00:00:00', 'W', 'W', 'W', 'W', '2014-07-13 00:00:00', 0, 0, 'W', 0, '', '', 0, '', '', 'W', 'Male', '0000-00-00 00:00:00', b'1', 'W'),
(790, 'ankit kulkarni', 'gajanand kulkarni', '231/11 hatesingh colony dewas', '1991-02-10 00:00:00', 'MCA', 'department of CS', 'indore', 'senior engineer', '2014-07-14 00:00:00', 0, 0, '9394930202', 0, 'Ajeet Khan', '21', 0, '', '', 'General', 'Male', '0000-00-00 00:00:00', b'1', 'AB+'),
(791, 'DDV', 'DVDV', 'SCVJHKJHFFF', '2014-07-14 00:00:00', 'GKH;H', 'MHK', 'HKJLLJL', 'HGKHK', '2014-07-14 00:00:00', 0, 0, 'LJLJL', 0, '', '', 0, '', '', 'SSSSSSS', 'Others', '0000-00-00 00:00:00', b'1', 'DHGDHJHJG');

-- --------------------------------------------------------

--
-- Table structure for table `cmcs_nominee`
--

CREATE TABLE IF NOT EXISTS `cmcs_nominee` (
  `nominee_id` int(11) NOT NULL AUTO_INCREMENT,
  `member_id` int(11) NOT NULL,
  `name` varchar(255) DEFAULT NULL,
  `relation_with_member` varchar(255) DEFAULT NULL,
  `contact_no` int(11) DEFAULT NULL,
  PRIMARY KEY (`nominee_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=10001 ;

--
-- Dumping data for table `cmcs_nominee`
--

INSERT INTO `cmcs_nominee` (`nominee_id`, `member_id`, `name`, `relation_with_member`, `contact_no`) VALUES
(1, 0, 'xyz', 'brother', 2147483647),
(21, 0, 'ffefe', 'rgege', 2147483647),
(788, 0, 'W', 'W', 0),
(789, 0, 'W', 'W', 0),
(790, 0, 'jumru kulkarni', 'son', 2147483647),
(791, 0, 'jumru kulkarni', 'son', 0),
(10000, 54, 'n', 'n', 9999);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
