using System.Runtime.CompilerServices;

public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value == Data){
            
        } else if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        // TODO Start Problem 2
        if(Data == value){
            return true;
        }else if(Data < value){
            if(Right is null){
                return false;
            }else if(Right.Contains(value)){
                return true;
            }
        }else{
            if(Left is null){
                return false;
            }else if(Left.Contains(value)){
                return true;
            }
        }
        return false;
    }

    public int GetHeight() {
        // TODO Start Problem 4
        // Replace this line with the correct return statement(s)

        int left = 1;
        int right = 1;
        if(Left is not null){
            left = Left.GetHeight()+1;
        }
        if(Right is not null){
            right = Right.GetHeight()+1;
        }

        return(Math.Max(left, right));
    }
}