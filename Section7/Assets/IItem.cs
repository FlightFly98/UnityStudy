public interface IItem
{
    void Use();
    // 상속받는 클래스는 무조건 인터페이스의 함수를 만들어야 함.
    // 내부 구현 못함, 멤버 변수 x, 오로지 껍데기
}

/*

void OnTriggerEnter(Collider2D other)
{
    IItem item = other.GetComponent<IItem>();
    if(item != null)
    {
        item.Use();
    }
    // 이런 식으로 만들었을 때 인터페이스 함수는 사용 가능, 고유 클래스의 함수는 사용 불가
}

*/