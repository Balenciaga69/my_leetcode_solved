interface User {
  firstName: string
  lastName: string
  gender: 'male' | 'female'
  age: number
  married: boolean
}
const users: User[] = [
  {
    firstName: 'Freddie',
    lastName: 'Hong',
    gender: 'male',
    age: 32,
    married: true,
  },
  {
    firstName: 'Shaquille',
    lastName: 'Fang',
    gender: 'male',
    age: 3,
    married: false,
  },
  {
    firstName: 'Justin',
    lastName: 'Fan',
    gender: 'male',
    age: 42,
    married: true,
  },
  {
    firstName: 'Sophia',
    lastName: 'Liu',
    gender: 'female',
    age: 12,
    married: false,
  },
  {
    firstName: 'Maxwell',
    lastName: 'Jeng',
    gender: 'male',
    age: 43,
    married: false,
  },
]
/*
GPT: 在英文習慣裡：
男性無論婚否 → 一律用 Mr.
女性：
若已婚 → 用 Mrs.
若未婚 → 用 Ms.（或 Miss，但現代寫法多用 Ms.）
*/
const ProcessUsers = (users: User[]): string[] =>
  users.map((e, idx) => `${idx + 1}. ${ToMr(e.gender, e.married)} ${e.firstName} ${e.lastName} (age ${e.age})`)

const ToMr = (gender: User['gender'], married: User['married']) =>
  gender === 'male' ? 'Mr.' : married ? 'Mrs.' : 'Ms.'

const result = ProcessUsers(users)
console.info('xZx result', result)
