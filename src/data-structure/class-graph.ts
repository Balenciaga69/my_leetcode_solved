export class GraphNode {
  val: string = "";
  friends: GraphNode[] = [];
  visited: boolean = false;
  constructor(val: string) {
    this.val = val;
  }
}
