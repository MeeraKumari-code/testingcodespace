// declare an array of string with country names
var countries = ["India", "USA", "Japan", "Russia"];
//declar an array of object with country and its code
var countriesWithCode = [

    { name: "India", code: "IN" },
    { name: "USA", code: "US" },
    { name: "Japan", code: "JP" },
    { name: "Russia", code: "RU" }
];
//create a function to sort by country name
function sortByName() {
    countries.sort();
    console.log(countries);
}
//create a function to calculate factorial of a number using recurssion
function factorial(n) {
    if (n == 0) {
        return 1;
    }
    else {
        return n * factorial(n - 1);
    }
}
