function randomArray(len: number, min = 0, max = 100000) {
  return Array.from({ length: len }, () => Math.floor(Math.random() * (max - min + 1)) + min)
}

const sequence = randomArray(5, 1, 99)
bubbleSort(sequence)

function bubbleSort(sequence: number[]) {
  let log_times = 1
  for (let i = 0; i < sequence.length; i++) {
    for (let j = 0; j < sequence.length - 1; j++) {
      let log_swapped = false
      if (sequence[j] > sequence[j + 1]) {
        log_swapped = true
        ;[sequence[j], sequence[j + 1]] = [sequence[j + 1], sequence[j]]
      }
      console.info(`[i:j] [${i}:${j}],swapped:[${log_swapped}] times:${log_times++} sequence ${sequence}`)
    }
  }
}
