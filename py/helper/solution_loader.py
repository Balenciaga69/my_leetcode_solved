from importlib.util import module_from_spec, spec_from_file_location
from pathlib import Path


def load_solution_class(solution_file: str):
    # 取得解答檔路徑。
    path = Path(solution_file)
    # 建立該檔案的 module spec。
    spec = spec_from_file_location(f"solution_{path.stem}", path)
    # 依照 spec 建立 module 物件。
    module = module_from_spec(spec)
    # 確認 loader 存在，避免後面執行時出錯。
    assert spec.loader is not None
    # 執行該 module，讓裡面的 Solution 類別可被載入。
    spec.loader.exec_module(module)
    # 回傳題目的 Solution 實體。
    return module.Solution()
