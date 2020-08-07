
export const foo = 123;
export type someType = {
    foo: string;
}

interface Point {
    x: number,
    y: number
}
declare const myPoint: Point

// Lib b.d.ts
interface Point {
    z: number
}

myPoint.z 

enum CardSuit {
    Clubs,
    Diamonds,
    Hearts,
    Spades
}

// 简单的使用枚举类型
let Card = CardSuit.Clubs;
 