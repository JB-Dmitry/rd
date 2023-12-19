#ifndef RD_CPP_SINGLETHREADSCHEDULERBASE_H
#define RD_CPP_SINGLETHREADSCHEDULERBASE_H

#include "scheduler/base/IScheduler.h"
#include "lifetime/Lifetime.h"
#include "spdlog/spdlog.h"

#include <utility>

#include <rd_framework_export.h>

RD_PUSH_STL_EXPORTS_WARNINGS

namespace ctpl
{
class thread_pool;
}

namespace rd
{
class RD_FRAMEWORK_API SingleThreadSchedulerBase : public IScheduler
{
protected:
	std::shared_ptr<spdlog::logger> log;
	std::string name;

	std::atomic_uint32_t tasks_executing{0};
	std::atomic_uint32_t active{0};
	std::unique_ptr<ctpl::thread_pool> pool;

	class PoolTask
	{
		std::function<void()> f;
		SingleThreadSchedulerBase* scheduler;

	public:
		explicit PoolTask(std::function<void()> f, SingleThreadSchedulerBase* scheduler);

		void operator()(int id) const;
	};

public:
	// region ctor/dtor
	SingleThreadSchedulerBase(std::string name);

	virtual ~SingleThreadSchedulerBase();
	// endregion

	void flush() override;

	void queue(std::function<void()> action) override;

	bool is_active() const override;
};
}	 // namespace rd

RD_POP_STL_EXPORTS_WARNINGS

#endif	  // RD_CPP_SINGLETHREADSCHEDULERBASE_H
