"use strict";

function Person(name, age, sex) {
    this.Age = age;
    this.Name = name;
    this.Sex = sex;
    this.CalcBirthYear = () => {
        let currentYear = new Date().getFullYear();
        return currentYear - this.Age;
    };
    this.DisplayData = () => {
        console.log(`
            Имя: ${this.Name}\n 
            Возраст: ${this.Age}\n 
            Пол: ${this.Sex}\n 
            Год рождения: ${this.CalcBirthYear()}\n
            Тип объекта: ${typeof this}`);
    };
    this.changeAge = changePersonsAge;
}

function changePersonsAge(age) {
    this.Age = age;
}

let John = new Person("John Smith", 33, "male");
John.changeAge(30);
John.DisplayData();
let Lauren = new Person("Lauren Faust", 25, "female");
Lauren.DisplayData();
let JohnTheJSON = JSON.stringify(John);
console.log(JohnTheJSON);
let JohnTheObject = JSON.parse(JohnTheJSON);
console.log(`
    Имя: ${JohnTheObject.Name}\n 
    Возраст: ${JohnTheObject.Age}\n 
    Пол: ${JohnTheObject.Sex}`);
//closures
function pow(exp) {
    return num => {
        let result = num;
        for (let i = 1; i < exp; i++) {
            result *= num;
        }
        return result;
    };
}
let power = pow(5);
console.log(power(5));
console.log(power(2));