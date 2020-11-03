-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mar. 03 nov. 2020 à 17:23
-- Version du serveur :  8.0.21
-- Version de PHP : 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `recette`
--

-- --------------------------------------------------------

--
-- Structure de la table `kaikai`
--

DROP TABLE IF EXISTS `kaikai`;
CREATE TABLE IF NOT EXISTS `kaikai` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) NOT NULL,
  `image` varchar(255) NOT NULL,
  `categorie` varchar(20) NOT NULL,
  `nbPersonnes` int NOT NULL,
  `ingredients` text NOT NULL,
  `preparations` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `kaikai`
--

INSERT INTO `kaikai` (`id`, `nom`, `image`, `categorie`, `nbPersonnes`, `ingredients`, `preparations`) VALUES
(1, 'Poisson cru lait de coco', '', 'Poissons', 3, '200 g Thon cru\r\n3 tomates\r\n2 carottes\r\n1 brique de lait de coco\r\n3 citrons verts\r\n1 oignon blanc\r\n1 concombre', 'Couper le Thon en cubes et les faire marinr dans le jus de 2 citrons pendant 15 minutes\r\nPendant ce temps couper les tomates en quartiers et l\'oignon en lamelles\r\nCouper les autres légumes en petites lamelles\r\nRincer légèrement le thon dans un saladier avec les légumes\r\nIncorporer le lait de coco et finir par le jus de citron'),
(2, 'Toe Toe Koehi', '', 'Fruits de mers', 3, '42 Toe Toe\r\n5 cocos\r\n100 gr curry\r\n1 cs sel\r\n1 litre verre d\'eau\r\n\r\n', 'Mettre les Toe Toe dans une marmite\r\nRajouter l\'eau, le sel\r\nFaire bouillir jusqu\'à évaporation\r\nRajouter le lait de coco\r\nRajouter le curry\r\nLaisser mariner et bon appétit'),
(3, 'Piha tunu kira', '', 'Viande', 3, '1 Piha\r\nfgsdfsdfhsdf\r\nhdfhdfhsdf\r\nhfhdfhdf\r\nhfdhsdfh\r\nhdfhdfhf', 'gdfhhsrhsdrh\r\nhrhdfhdhrhe\r\nhqrhdfhdhdrh\r\nhdrhdrherhq\r\nhqdfhrhsdrhsh\r\n7geryserh'),
(4, 'Mene Koehi', '', 'Chèvre', 3, 'ikujntgf\r\nkjnhfgvd\r\nkjnhbgfv\r\nlikjnhbg\r\nmlkjnhbg', 'mol;ikj,nhg\r\nlkj,nhbg\r\nkjnhbgfv\r\nlkjnhbg'),
(5, 'Poisson cru a la chinoise', '', 'Poissons', 3, '200 g Thon cru\r\n3 tomates\r\n2 carottes\r\n1 brique de lait de coco\r\n3 citrons verts\r\n1 oignon blanc\r\n1 concombre', 'Couper le Thon en cubes et les faire marinr dans le jus de 2 citrons pendant 15 minutes\r\nPendant ce temps couper les tomates en quartiers et l\'oignon en lamelles\r\nCouper les autres légumes en petites lamelles\r\nRincer légèrement le thon dans un saladier avec les légumes\r\nIncorporer le lait de coco et finir par le jus de citron'),
(6, 'Kaaku tea', '', 'Kaaku', 3, 'je sais pas\r\nje sais pas\r\nje sais pas\r\nje sais pas\r\nje sais pas\r\nje sais pas\r\nje sais pas\r\nje sais pas\r\nje sais pas\r\nje sais pas\r\nje sais pas\r\nje sais pas\r\nje sais pas\r\nje sais pas\r\nje sais pas', 'je sais pas\r\nje sais pas\r\nje sais pas\r\nje sais pas\r\nje sais pas\r\nje sais pas\r\nje sais pas\r\nje sais pas\r\nje sais pas\r\nje sais pas'),
(7, 'kaaku noir', '', 'Kaaku', 3, 'je sais pas\r\nje sais pas\r\nje sais pas\r\nje sais pas\r\nje sais pas', 'je sais pas\r\nje sais pas\r\nje sais pas\r\nje sais pas\r\nje sais pas');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
