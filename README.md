# Implementation of LUHN (mod10) check
* [Wikipedia reference] (https://en.wikipedia.org/wiki/Luhn_algorithm)

Steps to validate a bank card PAN (Primary Account Number):
1. Double the value of alternating digits, starting with the first digit and going as far as the second-last digit. The final digit should be ignored for this step and is the checksum digit.
2. Add the doubled values with the skipped values from step 1. Any number from step 1 that is a two digit number, add each digit together instead of adding the original number. For example, a result of 12 should be added as 1 + 2 = 3 (instead of 12.) 
3. A valid card as per the Luhn check will be divisible by 10.

## Examples
```
4062001210012105
 4   0   6   2   0   0   1   2   1   0   0   1   2   1   0   5
x2      x2      x2      x2      x2      x2      x2      x2
----------------------------------------------------------------
 8  +0 +1+2 +2  +0  +0  +2  +2  +2  +0  +0  +1  +4  +1  +0  +5

Sum: 30
     30 mod 10 = 0 (Pass)


5454545454545454
 5   4   5   4   5   4   5   4   5   4   5   4   5   4   5   4
x2      x2      x2      x2      x2      x2      x2      x2
----------------------------------------------------------------
+1  +4  +1  +4  +1  +4  +1  +4  +1  +4  +1  +4  +1  +4  +1  +4

Sum: 40
     40 mod 10 = 0 (Pass)
```