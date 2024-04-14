struct Stack {
    top: Option<Box<Node>>,
    height: usize,
}

struct Node {
    value: i32,
    next: Option<Box<Node>>,
}

impl Node {
    fn new(value: i32) -> Node {
        Node {
            value: value,
            next: None,
        }
    }
}

impl Stack {
    fn with_initial_value(value: i32) -> Stack {
        let new_node = Node::new(value);
        Stack {
            top: Some(Box::new(new_node)),
            height: 1,
        }
    }

    fn print_stack(&self) {
        let mut temp = &self.top;
        while let Some(node) = temp {
            println!("{}", node.value);
            temp = &node.next;
        }
    }

    fn get_top(&self) {
        if let Some(ref top_node) = self.top {
            println!("Top: {}", top_node.value);
        }
    }

    fn get_height(&self) {
        println!("Height: {}", self.height);
    }

    fn push(&mut self, value: i32) {
        let mut new_node = Node::new(value);
        if self.height == 0 {
            self.top = Some(Box::new(new_node));
        } else {
            new_node.next = self.top.take();
            self.top = Some(Box::new(new_node));
        }
        self.height += 1;
    }

    fn pop(&mut self) -> Option<Box<Node>> {
        if self.height == 0 {
            return None;
        }
        let mut temp = std::mem::replace(&mut self.top, None);
        if let Some(mut top_node) = temp.take() {
            self.top = top_node.next.take();
            self.height -= 1;
        }
        temp
    }
}

fn main() {
    let mut stack = Stack::with_initial_value(5);
    stack.push(10);
    stack.push(15);
    stack.print_stack();
    stack.get_top();
    stack.get_height();
    let popped = stack.pop();
    if let Some(node) = popped {
        println!("Popped value: {}", node.value);
    }
}
