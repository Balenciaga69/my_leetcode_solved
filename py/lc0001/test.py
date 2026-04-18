from pathlib import Path

from helper.solution_loader import load_solution_class


def test_two_sum():
    sol = load_solution_class(Path(__file__).with_name("sol.py"))

    test_cases = [
        ([2, 7, 11, 15], 9, [0, 1]),
        ([3, 2, 4], 6, [1, 2]),
        ([3, 3], 6, [0, 1]),
        ([1, 2, 3], 7, [-1, -1]),
    ]

    for nums, target, expected in test_cases:
        result = sol.twoSum(nums, target)
        assert result == expected
