Random Password Generator

Made in .Net Core MVC.

This project needs two parameters as input:

ID: int
Date: DateTime

After the form is completed, it will open another view with your random 16-character token.
This page is timed and will expire after 30 seconds.

For the token generation algorithm, I have used all the alphanumeric charaters, plus some special ones.
From these, I have removed "Ili1Oo0" to eliminate ambiguity. For the random picking, RandomNumberGenerator from
the Cryptography library has been used instead of the Random() method (insecure).

Filipoiu Alexandru Florin
0734511495
alexandru.filipoiu@gmail.com
