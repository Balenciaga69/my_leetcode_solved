function randomArray(len: number, min = 0, max = 100000): number[] {
  return Array.from({ length: len }, () => Math.floor(Math.random() * (max - min + 1)) + min)
}

const numList: number[] = randomArray(5, 1, 99)
console.info('xZx numList', numList)
