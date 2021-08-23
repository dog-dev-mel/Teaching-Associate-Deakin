# name.of.function = function(input1, input2) {
#     # Comment describing what the function does, or explaining a step in calculations.
#     # Sequence of calculations
# }

sumArray = function(arrayOfNumbers) {
    result = 0
    for (i in range(arrayOfNumbers)) {
        result = result + arrayOfNumbers[i]
    }
    result
}

sumArray.1 = function(arrayOfNumbers) {
    result = 0
    #R supports the double, integer, character, logical, complex and raw.
    if (typeof(arrayOfNumbers) == "double") {
        for (i in c(1:length(arrayOfNumbers))) {
            result = result + arrayOfNumbers[i]
        }
        result
    } else 
        print("Warning: There is a non-numeric element in your array.")
}

#Define the vector a is c(1,2,3,4,5)
a = c(1,2,3,4,5)

#Call the function sumArray
sumArray(a)

#Call the function sumArray.1
sumArray.1(a)
sumArray.1(c(9,4,"t",5))

#Define a function including mutiple variables
BMI = function(height, weight) {
    #The BMI, body mass index, is used to work out whether you are within a healthy weight range
    #Body Mass Index = weight(kg)/height(m^2)
    BMIResult = weight/(height^2) 
    BMIResult
}

BMI(1.69, 90)


#Exercise
length(c(1,2,3,4))
c(1:4)
c(1:20)

#Exercise a,b,c
f = function(x,y) {
    if (x == 0 && y == 0 ) {
        f_result = 0
    } 
    else if (x + y == 0) {
        print("the sum of x +y should not euqla zero")
        f_result = "The result is Null"
    } else
        f_result = (x^2 + y^2)/(x + y)
    f_result
}
f(0.3,0.9)
f(0.4,0.9)
f(0,0)
f(1,-1)

#Arithmetic mean Most situations
f_mean = function(meanArray) {
    f_mean_result = sum(meanArray)/length(meanArray)
    f_mean_result
}
f_mean(c(1,2,3,4,5,6,7,8,9,10))

#Middle of sorted list   Wildly varying samples
f_median = function(medianArray) {
    odd.even = length(medianArray) %% 2 
    if (odd.even == 0) {  
        (sort(medianArray)[length(medianArray)/2] + sort(medianArray)[1 + length(medianArray)/2])/2 
    } else { 
        (sort(medianArray)[ceiling(length(medianArray)/2)]) 
    } 
}
f_median(c(1,2,3,4,5,6,7,8,9,10))

#Most popular value   No compromises
f_mode = function(modeArray) {
    f_mode_result = unique(modeArray)[tabulate(match(modeArray, unique(modeArray))) == max(tabulate(match(modeArray, unique(modeArray))))]
    f_mode_result
}

f_mode(c(1,2,2,"c","c","c","c","c",4,4,5,5,5,5,5))
 
#Geometric Mean  Investments Growth area volume
#The geometric mean differs from the arithmetic average, or arithmetic mean, 
#in how it's calculated because it takes into account the compounding that occurs from period to period. 
#Because of this, investors usually consider the geometric mean a more accurate measure of returns than the arithmetic mean
gm_mean = function(x, na.rm=TRUE, zero.propagate = FALSE){
    if (any(x < 0, na.rm = TRUE)) {
        return(NaN)
    }
    if (zero.propagate) {
        if (any(x == 0, na.rm = TRUE)) {
            return(0)
        }
        exp(mean(log(x), na.rm = na.rm))
    } else {
        exp(sum(log(x[x > 0]), na.rm = na.rm) / length(x))
    }
}
gm_mean(c(1,2,3,4))
gm_mean(c(0,1,2,3,4))
gm_mean(c(0,0,0,0,0))

#Harmonic Mean/Subcontrary mean tiao he ping jun shu  Speed Production cost
HM = function(x) {
    if (prod(x) == 0) {
        return(0)
    } else {
        length(x)/sum(1/x)
    }
}


#Power mean
PM = function(x, p) {
    if (p == 0) {
        prod(x)^{1/length(x)}
    } else {
        mean(x^p)^{1/p}
    }
}

PM(2,0)
PM(c(2,3,4),2)

arrayIntegers=seq(1,10,by=2) 

PM(arrayIntegers,100)
PM(arrayIntegers,50)
PM(arrayIntegers,1)
PM(arrayIntegers,0)
PM(arrayIntegers,-50)
PM(arrayIntegers,-100)

PM(arrayIntegers,1)
f_mean(arrayIntegers)

geometric.mean(arrayIntegers)
PM(arrayIntegers,0)

harmonic.mean(arrayIntegers)
PM(arrayIntegers,-1)

#install.packages("psych") in the console
#geometric.mean   harmonic.mean
library(psych)
geometric.mean(c(3,5))

harmonic.mean(c(3,5))

harmonic.mean(c(4,4))

harmonic.mean(c(0,1),zero = FALSE)
harmonic.mean(c(0,1),zero = TRUE)
#How To Analyze Data Using the Average
#https://betterexplained.com/articles/how-to-analyze-data-using-the-average/


runif(20, min = 1, max = 10)
