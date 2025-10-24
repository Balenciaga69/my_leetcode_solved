// 基本上當時工作在寫前端的時候 大多數時間都是用 const ... 以及 {...prev, newProp: newState }
// 反而直接 let,var 或者 直接改寫某個欄位　可能更容易被退 code review

// 根據過往經驗 修改 Redux Reducer 新狀態的時候 都是
function someReducer(state = { count: 0 }, action: any) {
  if (action.type === 'somethingXXX') {
    return { ...state, count: state.count + 1 }
  }
  return state
}

// Object.assign,或攤開
const user = { name: 'Alice', age: 20, otherInfo: { fatherName: 'Jay', motherName: 'Amy' } }

const assignedNewUser = Object.assign({}, user, { age: 21 })

const expandedUser = {
  ...user,
  age: 21,
  otherInfo: { ...user.otherInfo, motherName: 'nextFather' },
}
user.age = 99

console.info('assignedNewUser', assignedNewUser)
console.info('expandedUser', expandedUser)
console.info('original user (被修改了)', user)
