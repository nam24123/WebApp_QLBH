# Bài tập chung 
	Chứa các thư mục bài tập từng tuần của các thành viên trong nhóm từng tuần.
	Pull requests chứa các yêu cầu thành viên chỉnh sửa code ở các nhánh và chỉ được xác nhận
	ở nhánh chính khi người quản trị xác nhận
# Project chính(WebApp)
	Được thực hiện sau khi hoàn thành các bài tập chung và hiểu được cách lập một website asp.net mvc
# Git
	git status : trạng thái của Repo
	git status -s : trạng thái của Repo ngắn gọn
	git clone path : sao chép một Repository có địa chỉ là path
	git add : cập nhật vào staged
	git add filename : thêm file vào staged
	git add *.c : file có phần mở rộng .c
	git add -A : thêm mọi thứ có sự thay đổi (file mới, xóa file, nội dung thay đổi ...)
	git add . :thêm mọi thứ trừ loại xóa file
	git add - : thêm mọi thứ trừ file mới
	git commit -m "Thông báo ..." : commit mới
	git commit --amend -m "Thông báo ..." : commit + cập nhật vào commit cuối
	git log : lịch sử commit
	git log -4 : lịch sử 4 commit
	git log -4 -p : lịch sử 4 commit + chi tiết thay đổi
	git log --pretty=oneline : Hiện thị trực quan trên 1 dòng
	git log --oneline : Hiện thị trên 1 dòng
	git diff : Xem sự khác biệt giữa thư mục làm việc và staged
	git diff --staged : Xem sự khác biệt giữa staged và commit cuối
	git rm filename : xóa file
	git reset HEAD filename : hủy thay đổi của file
	git checkout -- filename : khôi phục thay đổi của file
	git checkout [hash] filename : khôi phục từ commit có mã hash
	git checkout [hash] . : khôi phục các file từ commit có mã hash
	git clean -d -fx :Xóa các file không được theo dõi, có ích khi muốn xóa bỏ nhanh các file không được theo dõi
	
	**Làm việc với nhánh
	git branch : liệt kê các nhánh
	git branch -v : liệt kê các nhánh + commit cuối
	git branch --merged : các nhánh gộp vào nhánh này
	git branch --no-merged : các nhánh không gộp vào nhánh này
	git branch branchname : tạo nhánh mới
	git checkout -b branchname : tạo nhánh mới, khi đang đứng ở một snapshot cũ
	git checkout branchname : chuyển nhánh
	git merge branchname : gộp nhánh với nhánh hiện tại
	git base branchname : gộp nhánh với nhánh hiện tại
	git mergetool : công cụ trực quan xử lý xung đột merge
	git branch -d branchname : xóa nhánh
	Xóa nhánh: --git branch -d feature-1.
	Xóa trên repo:--git push origin --delete feature-branch
	
	Sau khi thêm một thư mục mới vào file Git để push lên kho repo
	--git add .
	Sau khi đã thêm các thư mục mới vào staging area, bạn cần commit các thay đổi 
	--git commit -m ".."
	Cuối cùng, bạn có thể đưa các thay đổi từ kho lưu trữ cục bộ của bạn lên kho lưu
	trữ từ xa (nếu đã liên kết) bằng lệnh git push
	--git push origin master

	Merge nhánh:git merge feature-1
Sau khi hoàn thành công việc trên nhánh mới, bạn có thể merge nhánh đó vào branch chính bằng lệnh git merge <tên_nhánh>. Ví dụ, nếu bạn muốn merge nhánh feature-1 vào branch master, bạn có thể sử dụng lệnh git merge feature-1 khi đang đứng trên branch master.


Lưu ý: Trước khi merge nhánh mới vào branch chính, bạn nên đảm bảo rằng nhánh mới đã được test và hoạt động tốt. Nếu không, bạn có thể gây ra lỗi và ảnh hưởng đến toàn bộ project.
