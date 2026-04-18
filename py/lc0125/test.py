from pathlib import Path
import pytest

from helper.solution_loader import load_solution_class


def test_is_palindrome():
    sol = load_solution_class(Path(__file__).with_name("sol.py"))
    test_cases = [
        # 題目給的例子
        ("A man, a plan, a canal: Panama", True),
        ("race a car", False),
        (" ", True),
        # 基本情況
        ("a", True),
        ("ab", False),
        ("aa", True),
        # 數字
        ("121", True),
        ("123", False),
        # 混合字母 + 數字
        ("1a2", False),
        ("1a1", True),
        # 大小寫混合
        ("Aa", True),
        ("Ab", False),
        # 含符號
        ("!@#$$#@!", True),
        ("0P", False),
        # 邊界
        ("", True),
    ]

    for s, expected in test_cases:
        result = sol.isPalindrome(s)
        assert result == expected
