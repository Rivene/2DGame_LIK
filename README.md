# 이인규

1. 씬 구성
   1-1. 인트로 씬 : 게임 시작 시 초기 화면으로, 버튼 클릭 시 메인 씬으로 이동
   1-2. 메인 씬 : 플레이어가 키보드/마우스를 통해 캐릭터 제어

2. 플레이어 기능
   2-1. 키보드를 통해 캐릭터 이동
   2-2. 마우스를 통해 좌우 반전
   2-3. 스페이스 바를 통해 점프
   2-4. 마우스 좌클릭을 통해 공격

3. NPC 기능
   3-1. 기본 idle 애니메이션 반복
   3-2. 플레이어 위치에 따라 방향 전환
   3-3. 플에이어와 가까워지면 UI 상호작용

4. Tile Map 구현
   4-1. Floor, BackWall, FrontWall, Collider로 구성
   4-2. Collider는 보이지 않으며 플레이어와 충돌만 구현
