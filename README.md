# Bài tập chung 
	Chứa các thư mục bài tập từng tuần của các thành viên trong nhóm từng tuần.
	Pull requests chứa các yêu cầu thành viên chỉnh sửa code ở các nhánh và chỉ được xác nhận
	ở nhánh chính khi người quản trị xác nhận
# Project chính(WebApp)
	Được thực hiện sau khi hoàn thành các bài tập chung và hiểu được cách lập một website asp.net mvc
# Git
	Sau khi thêm một thư mục mới vào file Git để push lên kho repo
	--git add .
	Sau khi đã thêm các thư mục mới vào staging area, bạn cần commit các thay đổi 
	--git commit -m ".."
	Cuối cùng, bạn có thể đưa các thay đổi từ kho lưu trữ cục bộ của bạn lên kho lưu
	trữ từ xa (nếu đã liên kết) bằng lệnh git push
	--git push origin master
	Checkout vào branch chính:--git checkout master (để checkout vào branch chính).
Trước khi tạo nhánh mới, nên checkout vào branch chính (thường là branch master) để đảm bảo rằng bạn đang đứng trên phiên bản mới nhất của project .

	Tạo nhánh mới:--git branch feature-1.
Sau khi checkout vào branch chính, bạn có thể tạo nhánh mới bằng lệnh git branch <tên_nhánh>. Ví dụ, nếu bạn muốn tạo một nhánh mới có tên là feature-1

	Chuyển sang nhánh mới:--git checkout feature-1.
Sau khi tạo nhánh mới, bạn cần chuyển sang nhánh đó để có thể làm việc trên nhánh mới. Bạn có thể sử dụng lệnh git checkout <tên_nhánh> để chuyển sang nhánh mới. Ví dụ, nếu bạn muốn chuyển sang nhánh feature-1

	Kiểm tra xem bạn đang ở nhánh nào bằng lệnh sau:--git branch

	Chuyển nhánh khác:--git checkout <name>

Làm việc trên nhánh mới: Khi đã chuyển sang nhánh mới, bạn có thể làm việc trên nhánh đó bằng các lệnh git như thêm, sửa, xóa file, commit và push.

	Merge nhánh:git merge feature-1
Sau khi hoàn thành công việc trên nhánh mới, bạn có thể merge nhánh đó vào branch chính bằng lệnh git merge <tên_nhánh>. Ví dụ, nếu bạn muốn merge nhánh feature-1 vào branch master, bạn có thể sử dụng lệnh git merge feature-1 khi đang đứng trên branch master.

	Xóa nhánh: --git branch -d feature-1.
Sau khi đã merge nhánh mới vào branch chính, bạn có thể xóa nhánh đó bằng lệnh git branch -d <tên_nhánh>. Ví dụ, nếu bạn muốn xóa nhánh feature-1, 


	Xóa trên repo:--git push origin --delete feature-branch

Lưu ý: Trước khi merge nhánh mới vào branch chính, bạn nên đảm bảo rằng nhánh mới đã được test và hoạt động tốt. Nếu không, bạn có thể gây ra lỗi và ảnh hưởng đến toàn bộ project.
