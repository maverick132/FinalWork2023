## Create schema `humanFriendsdb`;
use `humanFriendsdb`;

CREATE TABLE pets (
  idpets INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  petsName VARCHAR(45),
  petsBirthday DATE
);