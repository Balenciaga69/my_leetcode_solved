var threeSum = function (ary) {
  ary.sort(function (a, b) {
    return a - b;
  });
  var target,
    result = [],
    len = ary.length;
  for (var i = 0; i < len; i++) {
    if (target === ary[i]) {
      continue;
    } else {
      target = ary[i];
    }
    var low = i + 1;
    var high = len - 1;
    while (low < high) {
      if (ary[low] + ary[high] === -target) {
        result.push([target, ary[low], ary[high]]);
        do {
          low++;
        } while (ary[low] === ary[low - 1]);
      } else if (ary[low] + ary[high] < -target) {
        low++;
      } else {
        high--;
      }
    }
  }
  return result;
};
const ary = [-1, 0, 1, 2, -1, -4];
threeSum(ary);
