# Implement the Fraction class according to the following requirements:

## Propeties:
- Numer: Numerator
- Denom: Denominator (default=1, cannot be 0)
- Count: counting #objects of this class (static)
Note: Numerator and Denominator have to in the minimal form.
      See r3 and r6.

## Constructors:
- Fraction (): default constructor
- Fraction (Fraction a): copy constructor
- Fraction (numerator, denominator)
note: increment the Count property when an object is created

## Methods
- setValue: set fraction value
- GCD: calculate Greatest Common Divisor of two integers (static)

## Operator Overloading:
many many operators need to be overloaded!!! 

## Question?
1. Is the number of Fraction objects equal to the 'new' keywords used
   in the 'main' methods? How come?
2. Are the result, r3 and r7, in case#1 and case#2 the same? Why?

## Answer
1.ไม่เท่ากัน เพราะในโอเปอเรเตอร์จะมีการเรียกใช้ Fraction Objects เท่ากับจำนวนครั้งของการทำงานของ Constructor
  Not equal because Operrator'll use Fraction Objects times equal number of Constructor working. 
2.ไม่เท่ากัน เพราะว่า จาก case#1 ค่าของr7 จะเท่ากับค่าของ r3 ที่ถูกฟังก์ชัน Fraction Objects สร้างขึ้นมาทำให้จำนวนครั้งของการสร้าง Fraction Objects เพิ่มขึ้นมาอีกหนึ่งครั้ง
					แต่ทว่า case#2 ค่าของr7 จะเท่ากับค่าของ r3 โดยตรง ไม่ผ่านการสร้างจาก Fraction Objects ทำให้จำนวนครั้งของการสร้าง Fraction Objects ไม่เพิ่มขึ้นมา
					ซึ่งถึงแม้ว่าจำนวนค่าการแสดงผลของcase#1&#2จะเท่ากัน แต่ทว่าความต่างของ case#1&2 ก็คือจะมีค่าของจำนวนครั้งของการสร้าง Fraction Objects ที่ไม่เท่ากัน โดย case#1>case#2 
  Not equal because case#1 point of r7 equal r3 that Fraction Objects created so time of Fraction Objects up 1 time		
					but case#2 point of r7 equal r3 directly,Not use Fraction Object created so time of Fraction Objects don't up time
					which although point of case#1 equal case#2 but time of Fraction Objects not equal by case#1>case#2 
## Expected Output:

***** 3 Fraction objects have been created *****
***** 8 Fraction objects have been created *****
***** 12 Fraction objects have been created *****
[Rational: 0/1], value=0]
[Rational: 2/1], value=2]
[Rational: 1/3], value=0.333333333333333]
[Rational: 2/1], value=2]
[Rational: 5/3], value=1.66666666666667]
[Rational: 4/1], value=4]
[Rational: 4/3], value=1.33333333333333]
[Rational: 8/1], value=8]
[Rational: 6/5], value=1.2]
True
True
False
[Rational: 10/1], value=10]
***** 12 Fraction objects have been created *****
GCD of 3650 and 360: 10
GCD of 3600 and 360: 360

