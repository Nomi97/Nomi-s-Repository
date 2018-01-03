import hello from './hello'

describe("calculator", ()=> {
it ("it should add both values",()=>{
expect(hello(5,2)).toBe(7)
})
})