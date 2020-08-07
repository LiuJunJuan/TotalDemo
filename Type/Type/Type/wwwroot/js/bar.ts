import { foo,someType } from './foo';

const bar = foo;

namespace Utility {
    export function log(msg: any) {
        if (typeof msg === 'string')
        console.log(msg);
    }
    export function error(msg: any) {
        console.log(msg);
    }
}

Utility.error('eee')

interface Name{  
    first: string;
    second: string;
}

let name: Name
name = {
    first: null,
    second: undefined
}

let numArr = [1, 2]
let reversedNums = numArr.reverse();

interface Windows {
    helloWorld(): void
}
//window.helloWorld = () => console.log("Test");