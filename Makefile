all:
	$(MAKE) -C cp
	cp cp/lib.so cs/lib.so
	dotnet build cs
	dotnet run --project cs
