from pathlib import Path

from helper.list_node import build_cycle_list, build_list
from helper.solution_loader import load_solution_class


def test_has_cycle():
    sol = load_solution_class(Path(__file__).with_name("sol.py"))

    assert sol.hasCycle(build_cycle_list([3, 2, 0, -4], 1)) is True
    assert sol.hasCycle(build_list([1, 2])) is False
    assert sol.hasCycle(build_cycle_list([1], 0)) is True
    assert sol.hasCycle(build_list([1])) is False
